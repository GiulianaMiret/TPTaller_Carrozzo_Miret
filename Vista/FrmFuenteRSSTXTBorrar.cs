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
using Vista.Core.Models;
using Vista.Logger;

namespace Vista
{
    public partial class FrmFuenteRSSTXTBorrar : Form
    {
        private readonly Fachada cFachada;
        private readonly ILogger cLogger;

        public FrmFuenteRSSTXTBorrar(Fachada pFachada, ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            InitializeComponent();
        }        

        private void radioButtonRSS_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewEliminar.DataSource = cFachada.GetAllRSS();
        }

        private void radioButtonTXT_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewEliminar.DataSource = cFachada.GetAllTXT();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewEliminar.CurrentRow.Index != -1)
                {
                    if (radioButtonRSS.Checked)
                    {
                        FuenteRSS mFuenteRSS = new FuenteRSS { Id = Convert.ToInt32(dataGridViewEliminar["Id", dataGridViewEliminar.CurrentRow.Index].Value) };
                        cFachada.DeleteFuenteRSS(mFuenteRSS);
                        radioButtonRSS_CheckedChanged(sender, e);
                    }
                    else
                    {
                        FuenteTextoFijo mFuenteTXT = new FuenteTextoFijo { Id = Convert.ToInt32(dataGridViewEliminar["Id", dataGridViewEliminar.CurrentRow.Index].Value) };
                        cFachada.DeleteFuenteTXT(mFuenteTXT);
                        radioButtonTXT_CheckedChanged(sender, e);
                    }
                }
            }
            catch (Exception exc)
            {
                cLogger.Debug(exc.Message);
                MessageBox.Show("Ocurrio un error: " + exc.Message);
            }            
        }
    }
}
