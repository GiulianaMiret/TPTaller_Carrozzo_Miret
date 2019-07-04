using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Core.Models;

namespace Vista
{
    public partial class FrmAgregarCampania : Form
    {
        private readonly Fachada iFachada;
        private readonly Logger.ILogger iLogger;
        private List<string> iImagenesSeleccionadas;

        public FrmAgregarCampania(Fachada fachada, Logger.ILogger logger)
        {
            iFachada = fachada;
            iLogger = logger;
            InitializeComponent();
        }

        private void FrmAgregarCampania_Load(object sender, EventArgs e)
        {
            IList<string> mListaNombres = iFachada.GetAllNamesFromImages();
            //dataGridViewTodasLasImagenes.DataSource = mListaNombres.Select(x => new { Nombre = x }).ToList();
            foreach(string mNombre in mListaNombres)
            {
                dataGridViewTodasLasImagenes.Rows.Add(mNombre);
            }
            dataGridViewTodasLasImagenes.Show();
            if (dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                Imagen mImagen = iFachada.GetImagenByName(mNombreImagen);
                pictureBoxVistaPreviaImagenes.Image = Utilidades.ByteToImage(mImagen.Hash);
            }
        }

        private void dataGridViewTodasLasImagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                Imagen mImagen = iFachada.GetImagenByName(mNombreImagen);
                pictureBoxVistaPreviaImagenes.Image = Utilidades.ByteToImage(mImagen.Hash);
            }

        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            if(dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();

                dataGridViewImagenesSeleccionadas.Rows.Add(mNombreImagen);
                dataGridViewImagenesSeleccionadas.Show();

                dataGridViewTodasLasImagenes.Rows.Remove(dataGridViewTodasLasImagenes.CurrentRow);
                dataGridViewTodasLasImagenes.Show();
            }

        }

        private void buttonQuitarImagen_Click(object sender, EventArgs e)
        {
            if (dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value.ToString();

                dataGridViewTodasLasImagenes.Rows.Add(mNombreImagen);
                dataGridViewTodasLasImagenes.Show();

                dataGridViewImagenesSeleccionadas.Rows.Remove(dataGridViewImagenesSeleccionadas.CurrentRow);
                dataGridViewImagenesSeleccionadas.Show();
            }

        }

        private void buttonConsultarDisponibilidad_Click(object sender, EventArgs e)
        {

        }

        private void btnCampaniaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCampaniaNombre.Text == "")
                {
                    throw new Exception("Falta ingresar el nombre de la campaña");
                }

                if ((Convert.ToInt32(comboBoxCampaniHoraInicio.Text) < 1) || (Convert.ToInt32(comboBoxCampaniHoraInicio.Text) > 24))
                {
                    throw new Exception("La hora de inicio ingresada no es válida");
                }

                if ((Convert.ToInt32(comboBoxCampaniaHoraFin.Text) < 1) || (Convert.ToInt32(comboBoxCampaniaHoraFin.Text) > 24))
                {
                    throw new Exception("La hora de fin ingresada no es válida");
                }

                //paso la info del datePicker y el combo a una sola variable
                DateTime mFechaInicio = new DateTime(
                                                    dateTimePickerCampaniaFechaInicio.Value.Year,
                                                    dateTimePickerCampaniaFechaInicio.Value.Month,
                                                    dateTimePickerCampaniaFechaInicio.Value.Day,
                                                    Convert.ToInt32(comboBoxCampaniHoraInicio.Text),
                                                    0,
                                                    0);
                DateTime mFechaFin = new DateTime(
                                                 dateTimePickerCampaniaFechaFin.Value.Year,
                                                 dateTimePickerCampaniaFechaFin.Value.Month,
                                                 dateTimePickerCampaniaFechaFin.Value.Day,
                                                 Convert.ToInt32(comboBoxCampaniaHoraFin.Text),
                                                 0,
                                                 0);

                if (mFechaInicio < DateTime.Now)
                {
                    throw new Exception("No se admiten Fechas de Inicios pasadas");
                }

                if (mFechaFin < mFechaInicio)
                {
                    throw new Exception("La Fecha Final debe ser mayor a la Fecha de Inicio");
                }

                if (iImagenesSeleccionadas == null)
                {
                    throw new Exception("Debe seleccionar al menos una imágen");
                }

                Campania mCampania = new Campania();
                mCampania.Nombre = textBoxCampaniaNombre.Text;
                mCampania.FechaInicio = mFechaInicio;
                mCampania.FechaFin = mFechaFin;

                foreach (string mNombreImagen in iImagenesSeleccionadas)
                {
                    mCampania.Imagenes.Add(iFachada.GetImagenByName(mNombreImagen));
                }

                iFachada.AddCampania(mCampania);

            }
            catch (Exception mExcepcion)
            {
                MessageBox.Show(mExcepcion.Message);
                iLogger.Debug(mExcepcion.Message);
            }

        }


        private void btnCampaniaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
