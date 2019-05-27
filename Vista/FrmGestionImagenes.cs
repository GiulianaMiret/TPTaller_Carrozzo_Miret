using Controlador;
using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmGestionImagenes : Form
    {
        private readonly Fachada iFachada;
        private readonly Logger.ILogger iLogger;
        public FrmGestionImagenes(Fachada fachada, Logger.ILogger logger)
        {
            iFachada = fachada;
            InitializeComponent();
        }

        private void btnExplorarBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOpenFileDialog = new OpenFileDialog();
            mOpenFileDialog.Filter = "Todas las imágenes soportadas|*.jpeg;*.png;*.bmp;*.ico";
            if (mOpenFileDialog.ShowDialog() == DialogResult.OK) pictureBoxImagen.Load(mOpenFileDialog.FileName);
            comboBoxImagen.Focus();
        }

        private void btnInsertarImagen_Click(object sender, EventArgs e)
        {
            Imagen mImagenAInsertar = new Imagen();
            mImagenAInsertar.Hash = Utilidades.ImageToByteArray(pictureBoxImagen);
            mImagenAInsertar.Nombre = comboBoxImagen.Text;
            try
            {
                iFachada.AddImagen(mImagenAInsertar);
            }
            catch (Exception ex)
            {
                iLogger.Error(ex.Message);
                throw new Exception("Ha ocurrido un error, comuniquese con su administrador.");
            }
        }

        private void comboBoxImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Imagen pImagen = iFachada.GetImagenByName(comboBoxImagen.Text);
            pictureBoxImagen.Image = Utilidades.ByteToImage(pImagen.Hash);
        }

        private void FrmGestionImagenes_Load(object sender, EventArgs e)
        {
            comboBoxImagen.Items.Insert(0, "Seleccione o cargue una imagen mediante el botón -->");
            foreach (var mNombreImagen in iFachada.GetAllNamesFromImages())
            {
                comboBoxImagen.Items.Add(mNombreImagen);
            }
        }
    }
}
