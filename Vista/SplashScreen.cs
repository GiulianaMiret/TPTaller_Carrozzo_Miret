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

namespace Vista
{
    public partial class SplashScreen : Form
    {
        private readonly Fachada cFachada;

        public SplashScreen(Fachada pFachada)
        {
            cFachada = pFachada;
            ActualizarFuentesRSS();
            InitializeComponent();
        }

        private void timerInicio_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(1);
            if (progressBar.Value == 20)
            {
                labelCargando.Text = "Cargando datos";
            }
            if (progressBar.Value == 50)
            {
                labelCargando.Text = "Estableciendo las conexiones";
            }
            if (progressBar.Value == 100)
            {
                timerInicio.Stop();
            }
        }

        private void ActualizarFuentesRSS()
        {
            var mFuentesRSS = cFachada.GetAllRSS();
            foreach (var mRSS in mFuentesRSS)
            {
                mRSS.Actualizar();
            }
        }
    }
}
