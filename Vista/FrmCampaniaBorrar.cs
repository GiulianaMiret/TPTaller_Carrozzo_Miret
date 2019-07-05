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
    public partial class FrmCampaniaBorrar : Form
    {
        public FrmCampaniaBorrar()
        {
            InitializeComponent();
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //Filtrar las campañas con los datos ingresados

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Guarda todas las campañas seleccionadas 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
