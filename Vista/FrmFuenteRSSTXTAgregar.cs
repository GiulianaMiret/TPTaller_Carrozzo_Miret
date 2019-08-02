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
        private readonly Fachada cFachada;
        private readonly ILogger cLogger;

        /// <summary>
        /// realizamos la injeccion de dependencias en el constructor
        /// ponemos en predeterminado el agregado de una fuente RSS
        /// </summary>
        /// <param name="fachada"></param>
        /// <param name="logger"></param>
        public FrmFuenteRSSTXTAgregar(Fachada pFachada, ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
            radioButtonRSS.Checked = true;
        }
        /// <summary>
        /// guarda una fuente en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFuenteGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //se realizan controles de valor nulo y de url valida
                if (textBoxTitulo.Text == "")
                {
                    throw new Exception("Por favor, ingrese un titulo para la fuente.");
                }
                else
                {
                    if (radioButtonRSS.Checked)
                    {
                        if (!Utilidades.UrlValida(textBoxURLfuente.Text))
                        {
                            throw new Exception("La URL no es válida. Por favor verifíquela.");
                        }
                        else
                        {
                            FuenteRSS mFuenteRSS = new FuenteRSS { Titulo = textBoxTitulo.Text, URL = textBoxURLfuente.Text };
                            string mCadena = "Se agregó la fuente: Id " + mFuenteRSS.Id + ", Título: " + mFuenteRSS.Titulo;
                            cLogger.Debug(mCadena);
                            cFachada.AddFuenteRSS(mFuenteRSS);
                            MessageBox.Show("La fuente RSS se agregó con éxito");
                        }
                    }
                    else
                    {
                        FuenteTextoFijo mFuenteTextoFijo = new FuenteTextoFijo { Titulo = textBoxTitulo.Text, Valor = textBoxTextoFijo.Text };
                        string mCadena = "Se agregó la fuente: Id " + mFuenteTextoFijo.Id + ", Título: " + mFuenteTextoFijo.Titulo;
                        cLogger.Debug(mCadena);
                        cFachada.AddFuenteTXT(mFuenteTextoFijo);
                        MessageBox.Show("La fuente se agregó con éxito");
                    }
                }
            }
            catch (Exception mException)
            {
                MessageBox.Show(mException.Message);
                cLogger.Debug(mException.ToString());
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

        private void actualizarValoresDeFuentesRSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //traigo todas las fuentes RSS y las mando a la fachada a updatearse
            var mListOfRSS = cFachada.GetAllRSS();
            try
            {
                foreach (var mRSS in mListOfRSS)
                {
                    mRSS.Actualizar();
                }
                MessageBox.Show("Las fuentes han sido actualizadas correctamente");
            }
            catch (Exception exc)
            {
                cLogger.Debug(exc.Message);
                MessageBox.Show("Ha ocurrido un error " + exc.Message);
            }            
        }

        private void btnFuenteCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
