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
        public SplashScreen()
        {
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
    }
}
