using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Logger;
using Core.Models;
using Controlador;

namespace Vista
{
    public partial class FrmFuenteRSSTXTModificar : Form
    {
        private readonly Fachada cFachada;
        private readonly ILogger cLogger;
        private FuenteRSS cFuenteRSS;
        private FuenteTextoFijo cFuenteTXT;

        public FrmFuenteRSSTXTModificar(Fachada pFachada, ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
            radioButtonRSS.Checked = true;
        }

        private void radioButtonRSS_CheckedChanged(object sender, EventArgs e)
        {
            lblTextoFijo.Visible = false;
            textBoxTextoFijo.Visible = false;
            lblURL.Visible = true;
            textBoxURLfuente.Visible = true;
            dataGridViewModificar.DataSource = cFachada.GetAllRSS();
        }

        private void radioButtonTXT_CheckedChanged(object sender, EventArgs e)
        {
            lblTextoFijo.Visible = true;
            textBoxTextoFijo.Visible = true;
            lblURL.Visible = false;
            textBoxURLfuente.Visible = false;
            dataGridViewModificar.DataSource = cFachada.GetAllTXT();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (radioButtonRSS.Checked)
            {
                List<FuenteRSS> mListaResultadoBusqueda = new List<FuenteRSS>();
                if (textBoxTitulo.Text != "")
                {
                    mListaResultadoBusqueda = cFachada.GetAllRSS().Where(x => x.Titulo.ToLower().Contains(textBoxTitulo.Text.ToLower())).ToList();
                    dataGridViewModificar.DataSource = mListaResultadoBusqueda;
                }
                else
                {
                    mListaResultadoBusqueda = cFachada.GetAllRSS().ToList();
                }
                dataGridViewModificar.DataSource = mListaResultadoBusqueda;
            }
            else
            {
                List<FuenteTextoFijo> mListaResultadoBusqueda = new List<FuenteTextoFijo>();
                if (textBoxTitulo.Text != "")
                {
                    mListaResultadoBusqueda = cFachada.GetAllTXT().Where(x => x.Titulo.ToLower().Contains(textBoxTitulo.Text.ToLower())).ToList();
                    dataGridViewModificar.DataSource = mListaResultadoBusqueda;
                }
                else
                {
                    mListaResultadoBusqueda = cFachada.GetAllTXT().ToList();
                }
                dataGridViewModificar.DataSource = mListaResultadoBusqueda;
            }
            
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            if (dataGridViewModificar.CurrentRow.Index != -1)
            {
                if(radioButtonRSS.Checked)
                {
                    FuenteRSS mFuenteRSS = new FuenteRSS { Id = Convert.ToInt32(dataGridViewModificar["Id", dataGridViewModificar.CurrentRow.Index].Value) };
                    cFuenteRSS = cFachada.GetFuenteRSS(mFuenteRSS);
                    textBoxTitulo.Text = cFuenteRSS.Titulo;
                    textBoxURLfuente.Text = cFuenteRSS.URL;
                }
                else
                {
                    FuenteTextoFijo mFuenteTXT = new FuenteTextoFijo { Id = Convert.ToInt32(dataGridViewModificar["Id", dataGridViewModificar.CurrentRow.Index].Value) };
                    cFuenteTXT = cFachada.GetFuenteTXT(mFuenteTXT);
                    textBoxTitulo.Text = cFuenteTXT.Titulo;
                    textBoxTextoFijo.Text = cFuenteTXT.Valor;
                }

            }

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if((cFuenteRSS != null) || (cFuenteTXT != null))
                {
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
                                cFuenteRSS.Titulo = textBoxTitulo.Text;
                                cFuenteRSS.URL = textBoxURLfuente.Text;
                                DialogResult mMessageBoxResultado = MessageBox.Show("¿Desea modificar la Fuente?", "Modificar Fuente", MessageBoxButtons.YesNo);
                                if (mMessageBoxResultado == DialogResult.Yes)
                                {
                                    cFachada.UpdateFuenteRSS(cFuenteRSS);
                                    MessageBox.Show("La fuente RSS se actualizó con éxito");
                                    dataGridViewModificar.DataSource = cFachada.GetAllRSS();
                                    string mCadena = "Se modificó la campaña: Id: " + cFuenteRSS.Id + ", Titulo: " + cFuenteRSS.Titulo;
                                    cLogger.Debug(mCadena);
                                }
                            }
                        }
                        else
                        {
                            cFuenteTXT.Titulo = textBoxTitulo.Text;
                            cFuenteTXT.Valor = textBoxTextoFijo.Text;
                            DialogResult mMessageBoxResultado = MessageBox.Show("¿Desea modificar la Fuente?", "Modificar Fuente", MessageBoxButtons.YesNo);
                            if (mMessageBoxResultado == DialogResult.Yes)
                            {
                                cFachada.UpdateFuenteTXT(cFuenteTXT);
                                MessageBox.Show("La fuente se actualizó con éxito");
                                dataGridViewModificar.DataSource = cFachada.GetAllTXT();
                                string mCadena = "Se modificó la campaña: Id: " + cFuenteTXT.Id + ", Titulo: " + cFuenteTXT.Titulo;
                                cLogger.Debug(mCadena);
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("No se han realizado modificaciones");
                }
            }
            catch (Exception mException)
            {
                MessageBox.Show(mException.Message);
                cLogger.Debug(mException.Message);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
