using Controlador;
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

namespace Vista
{
    public partial class FrmOperacion : Form
    {
        private readonly Fachada iFachada;
        private readonly ILogger iLogger;
        public FrmOperacion(Fachada pFachada, ILogger pLogger)
        {
            iFachada = pFachada;
            iLogger = pLogger;
            
            InitializeComponent();
        }

        private void FrmOperacion_Load(object sender, EventArgs e)
        {
            this.timerBanner_Tick(sender, e);


        }


        private void lblBanner_AutoSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void timerLabelBanner_Tick(object sender, EventArgs e)
        {
            this.lblBanner.Left -= 5;
            if (lblBanner.Right <= 0)
            {
                lblBanner.Left = Width;
            }
        }

        private void timerBanner_Tick(object sender, EventArgs e)
        {
            string mValorLabelTextoActual = iFachada.GetTextOfActualBanner();
            if (mValorLabelTextoActual != "")
            {
                lblBanner.Text = mValorLabelTextoActual;
            }

        }
    }
}
