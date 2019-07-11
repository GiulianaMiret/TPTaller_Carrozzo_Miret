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
    public partial class FrmCampaniaAgregar : Form
    {
        private readonly Fachada iFachada;
        private readonly Logger.ILogger iLogger;
        private List<string> iImagenesSeleccionadas = new List<string>();

        public FrmCampaniaAgregar(Fachada fachada, Logger.ILogger logger)
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

                iImagenesSeleccionadas.Add(mNombreImagen);
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

                iImagenesSeleccionadas.Remove(mNombreImagen);
            }

        }

        private void buttonConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            //dataGridViewHorariosDisponibles = null;
            dataGridViewHorariosDisponibles.Visible = true;

            DateTime mFechaInicio = dateTimePickerCampaniaFechaInicio.Value.Date;
            DateTime mFechaFin = dateTimePickerCampaniaFechaFin.Value.Date;

            int mDias = (mFechaFin - mFechaInicio).Days;
            //DateTime mColumnas = mFechaInicio;

            for (int i = 0; i <= mDias; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn()
                {
                    Name = (i+1).ToString(),
                    Width = 20,
                    ValueType = typeof(string),
                    CellTemplate = new DataGridViewTextBoxCell()
                };
                this.dataGridViewHorariosDisponibles.Columns.Add(column);
            }
            for (int i = 0; i < 24; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                this.dataGridViewHorariosDisponibles.Rows.Add(fila);
                this.dataGridViewHorariosDisponibles.Rows[i].HeaderCell.Value = (i+1).ToString();
            }
            //DGV Rangos Horarios Seleccionados
            this.dataGridViewHorariosDisponibles.AutoGenerateColumns = false;
            this.dataGridViewHorariosDisponibles.AutoSize = false;

            //Opción 1
            List<Campania> mListaCampanias1 = iFachada.FilterCampania(x =>
                                                    x.FechaInicio >= mFechaInicio &&
                                                    x.FechaInicio <= mFechaFin).ToList();

            foreach (Campania mCampania in mListaCampanias1)
            {
                int mHoraInicioCampania = mCampania.FechaInicio.Hour;
                int mHoraFinCampania = mCampania.FechaFin.Hour;
                int mDiferenciaDiasInicio = (mCampania.FechaInicio - mFechaInicio).Days;
                if (mFechaFin.Date <= mCampania.FechaFin.Date)
                {
                    for (int i = mDiferenciaDiasInicio; i == mDias; i++)
                    {
                        for (int j = mCampania.FechaInicio.Hour; j == mCampania.FechaFin.Hour; j++)
                        {
                            dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                        }

                    }
                }
                else
                {
                    int mDiferenciaDiasFin = (mFechaFin - mCampania.FechaFin).Days;
                    for (int i = mDiferenciaDiasInicio; i == mDiferenciaDiasFin; i++)
                    {
                        for (int j = mCampania.FechaInicio.Hour; j == mCampania.FechaFin.Hour; j++)
                        {
                            dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                        }
                    }
                }

            }

            //Opci+on 2
            List<Campania> mListaCampanias2 = iFachada.FilterCampania(x =>
                                                    x.FechaFin >= mFechaInicio &&
                                                    x.FechaFin <= mFechaFin &&
                                                    x.FechaInicio < mFechaInicio).ToList();
            foreach (Campania mCampania in mListaCampanias2)
            {
                int mHoraInicioCampania = mCampania.FechaInicio.Hour;
                int mHoraFinCampania = mCampania.FechaFin.Hour;
                int mDiferenciaDiasInicio = (mFechaInicio - mCampania.FechaInicio).Days;
                if (mFechaFin.Date <= mCampania.FechaFin.Date)
                {
                    for (int i = mDiferenciaDiasInicio; i == mDias; i++)
                    {
                        for (int j = mCampania.FechaInicio.Hour; j == mCampania.FechaFin.Hour; j++)
                        {
                            dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                        }

                    }
                }
                else
                {
                    int mDiferenciaDiasFin = (mFechaFin - mCampania.FechaFin).Days;
                    for (int i = mDiferenciaDiasInicio; i == mDiferenciaDiasFin; i++)
                    {
                        for (int j = mCampania.FechaInicio.Hour; j == mCampania.FechaFin.Hour; j++)
                        {
                            dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                        }
                    }
                }
            }

            //Opción 3
            List<Campania> mListaCampanias3 = iFachada.FilterCampania(x =>
                                                    x.FechaInicio <= mFechaInicio &&
                                                    x.FechaFin >= mFechaFin).ToList();

            foreach (Campania mCampania in mListaCampanias3)
            {
                int mHoraInicioCampania = mCampania.FechaInicio.Hour;
                int mHoraFinCampania = mCampania.FechaFin.Hour;

                if(mFechaInicio.Date >= mCampania.FechaInicio.Date)
                {
                    int mDiferenciaDiasInicio = (mFechaInicio - mCampania.FechaInicio).Days;
                    for(int i = mDiferenciaDiasInicio; i == mDias; i++)
                    {
                        for(int j = mCampania.FechaInicio.Hour; j == mCampania.FechaFin.Hour; j++)
                        {
                            dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                        }

                    }
                }
                else //mFechaInicio.Date < mCampania.FechaInicio.Date
                {
                    int mDiferenciaDiasInicio = (mCampania.FechaInicio - mFechaInicio).Days;
                    if (mFechaFin.Date <= mCampania.FechaFin.Date)
                    {
                        for (int i = mDiferenciaDiasInicio; i == mDias; i++)
                        {
                            for (int j = mCampania.FechaInicio.Hour; j == mCampania.FechaFin.Hour; j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                            }

                        }
                    }
                    else
                    {
                        int mDiferenciaDiasFin = (mFechaFin - mCampania.FechaFin).Days;
                        for (int i = mDiferenciaDiasInicio; i == mDiferenciaDiasFin; i++)
                        {
                            for (int j = mCampania.FechaInicio.Hour; j == mCampania.FechaFin.Hour; j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                            }
                        }
                    }

                }

            }

                
                

                //dataGridViewHorariosDisponibles.Rows[mHoraInicio].Cells[i.ToString()].Style.BackColor = Color.Red;
                //dataGridViewHorariosDisponibles.Rows[mHoraFin].Cells[i.ToString()].Style.BackColor = Color.Red;
            


            for (int i = 0; i <= mDias; i++)
            {
                for (int j = 0; j < 24; j++)
                {

                }
            }


            //for (int i = 0; i <= mDias; i++) //for (DateTime mColumnas = mFechaInicio; mColumnas > mFechaFin; mColumnas.AddDays(1))
            //{
            //    dataGridViewHorariosDisponibles.Columns.Add(i.ToString(), i.ToString());
            //    dataGridViewHorariosDisponibles.Columns[i].Width = 20;
            //    dataGridViewHorariosDisponibles.Rows.Add(24);


            //    mListaAuxiliar = mListaCampanias.Where(x => mColumnas.Date >= x.FechaInicio.Date || 
            //                                                mColumnas.Date <= x.FechaFin.Date).ToList();
            //    if(mListaAuxiliar.Count() > 0)
            //    {
            //        int mHoraInicio = mListaAuxiliar.First().FechaInicio.Hour;
            //        int mHoraFin = mListaAuxiliar.First().FechaFin.Hour;

            //        dataGridViewHorariosDisponibles.Rows[mHoraInicio].Cells[i.ToString()].Style.BackColor = Color.Red;
            //        dataGridViewHorariosDisponibles.Rows[mHoraFin].Cells[i.ToString()].Style.BackColor = Color.Red;
            //        //dataGridViewHorariosDisponibles.Rows[mHoraInicio].DefaultCellStyle.BackColor = Color.Red;
            //        //dataGridViewHorariosDisponibles.Columns[i].DefaultCellStyle.BackColor = Color.Red;
            //        //dataGridViewHorariosDisponibles.DefaultCellStyle.BackColor = Color.Red;
            //        //dataGridViewHorariosDisponibles.Columns[i].DefaultCellStyle.ForeColor = Color.Red;
            //    }

            //}





        }

        private void btnCampaniaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCampaniaNombre.Text == "")
                {
                    throw new Exception("Falta ingresar el nombre de la campaña");
                }

                if ((Convert.ToInt32(comboBoxCampaniHoraInicio.Text) < 1) || 
                    (Convert.ToInt32(comboBoxCampaniHoraInicio.Text) > 24))
                {
                    throw new Exception("La hora de inicio ingresada no es válida");
                }

                if ((Convert.ToInt32(comboBoxCampaniaHoraFin.Text) < 1) || 
                    (Convert.ToInt32(comboBoxCampaniaHoraFin.Text) > 24))
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

                if (mFechaInicio.Date < DateTime.Now.Date)
                {
                    throw new Exception("No se admiten Fechas de Inicios pasadas");
                }

                if (mFechaFin.Date < mFechaInicio.Date)
                {
                    throw new Exception("La Fecha Final debe ser mayor a la Fecha de Inicio");
                }

                Campania mCampania = new Campania();
                mCampania.Nombre = textBoxCampaniaNombre.Text;
                mCampania.FechaInicio = mFechaInicio;
                mCampania.FechaFin = mFechaFin;
                List<Imagen> mListaImagenes = new List<Imagen>();

                foreach (string mNombreImagen in iImagenesSeleccionadas)
                {
                    Imagen mImagen = iFachada.GetImagenByName(mNombreImagen);
                    mListaImagenes.Add(mImagen);
                }
                mCampania.Imagenes = mListaImagenes;

                if (iImagenesSeleccionadas == null)
                {
                    throw new Exception("Debe seleccionar al menos una imágen");
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

        private void dataGridViewHorariosDisponibles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //e.CellStyle.ForeColor = Color.Red;
            
        }
    }
}
