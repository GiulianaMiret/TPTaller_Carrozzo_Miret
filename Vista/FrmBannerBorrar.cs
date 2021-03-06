﻿using Controlador;
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
    public partial class FrmBannerBorrar : Form
    {
        private readonly Fachada cFachada;
        private readonly Logger.ILogger cLogger;

        public FrmBannerBorrar(Fachada fachada, Logger.ILogger logger)
        {
            cFachada = fachada;
            cLogger = logger;
            InitializeComponent();
        }

        private void FrmBannerBorrar_Load(object sender, EventArgs e)
        {
            dataGridViewBanners.DataSource = cFachada.GetAllBanner();
        }

        /// <summary>
        /// Filtra: Busca un banner con los datos ingresados dentro del datagrid y muestra solo el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Banner> mListaResultadoBusqueda = new List<Banner>();
            if (textBoxNombreBanner.Text != "")
            {
                mListaResultadoBusqueda = cFachada.GetAllBanner().Where(x => x.Nombre.ToLower().Contains(textBoxNombreBanner.Text.ToLower())).ToList();
                dataGridViewBanners.DataSource = mListaResultadoBusqueda;
            }
            else
            {
                mListaResultadoBusqueda = cFachada.GetAllBanner();
            }
            dataGridViewBanners.DataSource = mListaResultadoBusqueda;
        }

        /// <summary>
        /// Borra el banner que está actualmente seleccionado del datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBanners.CurrentRow.Index != -1)
                {
                    Banner mBanner = new Banner { Id = Convert.ToInt32(dataGridViewBanners["Id", dataGridViewBanners.CurrentRow.Index].Value) };
                    DialogResult mMessageBoxResultado = MessageBox.Show("¿Desea borrar el Banner?", "Borrar Banner", MessageBoxButtons.YesNo);
                    if (mMessageBoxResultado == DialogResult.Yes)
                    {
                        string mCadena = "Se borra el banner: Id: " + mBanner.Id;
                        cLogger.Debug(mCadena);
                        cFachada.DeleteBanner(mBanner);
                        dataGridViewBanners.DataSource = cFachada.GetAllBanner();
                        MessageBox.Show("El Banner se ha borrado exitosamente");
                    }
                }
            }
            catch (Exception mException)
            {
                cLogger.Debug(mException.Message);
                MessageBox.Show("Ocurrio un error: " + mException.Message);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
}
}
