//using Core.Models;
using Controlador;
using Core.Models;
using System;
using System.Windows.Forms;
using Vista.Logger;

namespace Vista
{
    public partial class FrmFuenteRSSTXTAgregar : Form
    {
        private readonly Fachada iFachada;
        private readonly ILogger iLogger;
        public FrmFuenteRSSTXTAgregar(Fachada fachada, ILogger logger)
        {
            iFachada = fachada;
            iLogger = logger;
            InitializeComponent();
            radioButtonRSS.Checked = true;
        }

        private void btnFuenteGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxTitulo.Text == "")
                {
                    MessageBox.Show("Por favor, ingrese un titulo para la fuente RSS.");
                }
                else
                {
                    if (!Utilidades.UrlValida(textBoxURLfuente.Text))
                    {
                        MessageBox.Show("La URL no es válida. Por favor verifíquela.");
                    }
                    else
                    {
                        if (radioButtonRSS.Checked)
                        {
                            FuenteRSS mFuenteRSS = new FuenteRSS { Titulo = textBoxTitulo.Text, URL = textBoxURLfuente.Text };
                            iFachada.AddFuenteRSS(mFuenteRSS);
                            Utilidades.MostrarMensajePopup("La fuente RSS se agregó con éxito");
                        }
                        else
                        {
                            FuenteTextoFijo mFuenteTextoFijo = new FuenteTextoFijo { Titulo = textBoxTitulo.Text, Valor = textBoxTextoFijo.Text };                            
                            
                        }
                        
                    }
                }
            }
            catch (Exception bError)
            {
                MessageBox.Show("No se ha podido cargar la fuente RSS, por favor verifique el Log para mas detalles.");
                iLogger.Debug(bError.ToString());
            }
            
            
        }

        private void radioButtonRSS_CheckedChanged(object sender, EventArgs e)
        {
            lblTextoFijo.Visible = false;
            textBoxTextoFijo.Visible = false;
            lblURL.Visible = true;
            textBoxURLfuente.Visible = true;
        }        

        private void radioButtonTXT_CheckedChanged(object sender, EventArgs e)
        {
            lblTextoFijo.Visible = true;
            textBoxTextoFijo.Visible = true;
            lblURL.Visible = false;
            textBoxURLfuente.Visible = false;
        }
    }
}
