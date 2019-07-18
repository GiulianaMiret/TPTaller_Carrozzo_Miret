using Controlador;
using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmImagenesGestion : Form
    {
        private readonly Fachada iFachada;
        private readonly Logger.ILogger iLogger;

        /// <summary>
        /// realizamos la injeccion de dependencias en el constructor
        /// </summary>
        /// <param name="fachada"></param>
        /// <param name="logger"></param>
        public FrmImagenesGestion(Fachada fachada, Logger.ILogger logger)
        {
            iFachada = fachada;
            iLogger = logger;
            InitializeComponent();
        }
        /// <summary>
        /// Evento que dispara el boton para seleeccionar una nueva imagen del explorador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExplorarBtn_Click(object sender, EventArgs e)
        {
            //creamos un nuevo OFDialog para que pueda seleccionar imagenes SOLO PNG
            OpenFileDialog mOpenFileDialog = new OpenFileDialog();
            mOpenFileDialog.Filter = "*.png|*.png";
            //si la seleccion resulta correcta, se carga la imagen y se pone el foco en el combobox para que coloque un nombre
            if (mOpenFileDialog.ShowDialog() == DialogResult.OK) pictureBoxImagen.Load(mOpenFileDialog.FileName);
            comboBoxImagen.Text = "COLOQUE AQUÍ EL NOMBRE DE LA IMAGEN";
            comboBoxImagen.Focus();
        }
        /// <summary>
        /// metodo que inserta una imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsertarImagen_Click(object sender, EventArgs e)
        {
            //se crea una nueva imagen para insertarla a traves de la fachada
            //se utiliza el procedimiento ImageToByteArray

            if (comboBoxImagen.Text == "COLOQUE AQUÍ EL NOMBRE DE LA IMAGEN")
            {
                MessageBox.Show("Por favor, elija un nombre para la imagen");
                return;
            }

            Imagen mImagenAInsertar = new Imagen();
            mImagenAInsertar.Hash = Utilidades.ImageToByteArray(pictureBoxImagen);
            mImagenAInsertar.Nombre = comboBoxImagen.Text; 
            try
            {
                iFachada.AddImagen(mImagenAInsertar);
                Utilidades.MostrarMensajePopup("Se agregó correctamente la imagen.");
                FrmGestionImagenes_Load(sender, e);
            }
            catch (Exception ex)
            {
                iLogger.Error(ex.Message);
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
        /// <summary>
        /// metodo para mostrar una imagen en el picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBoxImagen.SelectedIndex > 0)
            {
                //obtiene la imagen por nombre
                //se tiene la regla que dos imagenes no pueden contener el mismo nombre
                //regla aplicada en el agregar imagen 
                Imagen pImagen = iFachada.GetImagenByName(comboBoxImagen.Text);
                pictureBoxImagen.Image = Utilidades.ByteToImage(pImagen.Hash);
            }          
        }

        /// <summary>
        /// En el evento load cargamos los nombres de las imagenes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmGestionImagenes_Load(object sender, EventArgs e)
        {
            //limpio y obtengo todos los nombres de las imagenes
            //y los agrego al combobox para que puedan ser seleccionadas
            comboBoxImagen.Items.Clear();
            comboBoxImagen.Items.Insert(0, "Seleccione o cargue una imagen mediante el botón -->");
            var mListaDeNombresDeLasImagenes = iFachada.GetAllNamesFromImages();
            pictureBoxImagen.Image = null;
            foreach (var mNombreImagen in mListaDeNombresDeLasImagenes)
            {
                comboBoxImagen.Items.Add(mNombreImagen);                
            }
            comboBoxImagen.SelectedIndex = 0;
        }
        /// <summary>
        /// este metodo permite borrar una imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                Imagen mImagenABorrar = new Imagen();
                mImagenABorrar.Nombre = comboBoxImagen.Text;
                iFachada.DeleteImagen(mImagenABorrar);
                Utilidades.MostrarMensajePopup("Se borró correctamente la imagen.");
                FrmGestionImagenes_Load(sender, e);
            }
            catch (Exception exc)
            {
                    iLogger.Debug(exc.Message);
                    MessageBox.Show("Ha ocurrido un error: " + exc.Message);
            }
        }
    }
}
