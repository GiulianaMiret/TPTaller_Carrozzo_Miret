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
        private readonly Fachada cFachada;
        private readonly Logger.ILogger cLogger;

        /// <summary>
        /// realizamos la injeccion de dependencias en el constructor
        /// </summary>
        /// <param name="fachada"></param>
        /// <param name="logger"></param>
        public FrmImagenesGestion(Fachada fachada, Logger.ILogger logger)
        {
            cFachada = fachada;
            cLogger = logger;
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
                string mCadena = "Se agregó la Imagen: Id " + mImagenAInsertar.Id + ", Nombre: " + mImagenAInsertar.Nombre;
                cLogger.Debug(mCadena);
                cFachada.AddImagen(mImagenAInsertar);
                MessageBox.Show("Se agregó correctamente la imagen.");
                FrmGestionImagenes_Load(sender, e);
            }
            catch (Exception mException)
            {
                cLogger.Error(mException.Message);
                MessageBox.Show("Ha ocurrido un error: " + mException.Message);
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
                Imagen pImagen = cFachada.GetImagenByName(comboBoxImagen.Text);
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
            var mListaDeNombresDeLasImagenes = cFachada.GetAllNamesFromImages();
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

                DialogResult mMessageBoxResultado = MessageBox.Show("¿Desea borrar la Imagen?", "Borrar Imagen", MessageBoxButtons.YesNo);
                if (mMessageBoxResultado == DialogResult.Yes)
                {
                    string mCadena = "Se borra la Imagen: Id: " + mImagenABorrar.Id + ", Nombre: " + mImagenABorrar.Nombre;
                    cLogger.Debug(mCadena);
                    cFachada.DeleteImagen(mImagenABorrar);
                    MessageBox.Show("Se borró correctamente la imagen.");
                    FrmGestionImagenes_Load(sender, e);
                }
               
            }
            catch (Exception mException)
            {
                cLogger.Debug(mException.Message);
                MessageBox.Show("Ha ocurrido un error: " + mException.Message);
            }
        }
    }
}
