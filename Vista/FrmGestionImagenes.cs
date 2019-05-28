﻿using Controlador;
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
    public partial class FrmGestionImagenes : Form
    {
        private readonly Fachada iFachada;
        private readonly Logger.ILogger iLogger;
        private string iExtension;
        public FrmGestionImagenes(Fachada fachada, Logger.ILogger logger)
        {
            iFachada = fachada;
            iLogger = logger;
            InitializeComponent();
        }

        private void btnExplorarBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog mOpenFileDialog = new OpenFileDialog();
            mOpenFileDialog.Filter = "*.png|*.png";
            if (mOpenFileDialog.ShowDialog() == DialogResult.OK) pictureBoxImagen.Load(mOpenFileDialog.FileName);
            comboBoxImagen.Text = "COLOQUE AQUÍ EL NOMBRE DE LA IMAGEN";
            iExtension = Path.GetExtension(mOpenFileDialog.FileName);
            comboBoxImagen.Focus();
        }

        private void btnInsertarImagen_Click(object sender, EventArgs e)
        {
            Imagen mImagenAInsertar = new Imagen();
            mImagenAInsertar.Hash = Utilidades.ImageToByteArray(pictureBoxImagen, iExtension);
            mImagenAInsertar.Nombre = comboBoxImagen.Text; 
            try
            {
                iFachada.AddImagen(mImagenAInsertar);
                FrmGestionImagenes_Load(sender, e);
            }
            catch (Exception ex)
            {
                iLogger.Error(ex.Message);
                throw new Exception("Ha ocurrido un error, comuniquese con su administrador.");
            }
        }

        private void comboBoxImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBoxImagen.SelectedIndex > 0)
            {
                Imagen pImagen = iFachada.GetImagenByName(comboBoxImagen.Text);
                pictureBoxImagen.Image = Utilidades.ByteToImage(pImagen.Hash);
            }          
        }

        private void FrmGestionImagenes_Load(object sender, EventArgs e)
        {
            comboBoxImagen.Items.Clear();
            comboBoxImagen.Items.Insert(0, "Seleccione o cargue una imagen mediante el botón -->");
            var mListaDeNombresDeLasImagenes = iFachada.GetAllNamesFromImages();
            foreach (var mNombreImagen in mListaDeNombresDeLasImagenes)
            {
                comboBoxImagen.Items.Add(mNombreImagen);
            }
            comboBoxImagen.SelectedIndex = 0;
        }

        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                iFachada.DeleteImagen(pictureBoxImagen);
                FrmGestionImagenes_Load(sender, e);
            }
            catch (Exception Exc)
            {
                throw new Exception(Exc.Message);
            }
        }
    }
}
