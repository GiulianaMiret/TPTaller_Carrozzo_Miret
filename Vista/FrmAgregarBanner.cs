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
    public partial class FrmAgregarBanner : Form
    {
        public FrmAgregarBanner()
        {
            InitializeComponent();
        }

        private void radioButtonTextoFijo_Click(object sender, EventArgs e)
        {
            groupBoxRSS.Visible = false;
            groupBoxTextoFijo.Visible = true;
        }

        private void radioButtonRSS_Click(object sender, EventArgs e)
        {
            groupBoxTextoFijo.Visible = false;
            groupBoxRSS.Visible = true;
        }

        private void btnBannerGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
