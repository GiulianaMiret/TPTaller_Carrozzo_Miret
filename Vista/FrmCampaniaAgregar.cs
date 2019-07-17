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
            foreach(string mNombre in mListaNombres)
            {
                dataGridViewTodasLasImagenes.Rows.Add(mNombre);
            }
            dataGridViewTodasLasImagenes.Show();
            if(dataGridViewTodasLasImagenes.CurrentRow != null)
            { 
                if (dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
                {
                    string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                    Imagen mImagen = iFachada.GetImagenByName(mNombreImagen);
                    pictureBoxVistaPreviaImagenes.Image = Utilidades.ByteToImage(mImagen.Hash);
                }
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
            dataGridViewHorariosDisponibles = new DataGridView();
            dataGridViewHorariosDisponibles.Visible = true;
            

            if (dateTimePickerCampaniaFechaInicio.Value.Date >= DateTime.Now.Date)
            {
                if (dateTimePickerCampaniaFechaInicio.Value.Date <= dateTimePickerCampaniaFechaFin.Value.Date)
                {
                    DateTime mFechaInicio = dateTimePickerCampaniaFechaInicio.Value;
                    DateTime mFechaFin = dateTimePickerCampaniaFechaFin.Value;
                    int mCantidadColumnas = (mFechaFin - mFechaInicio).Days;

                    for (int i = 0; i <= mCantidadColumnas; i++)
                    {
                        DataGridViewColumn mColumna = new DataGridViewColumn()
                        {
                            //Name = (i + 1).ToString(),
                            Name = (mFechaInicio.Day + i).ToString(),
                            Width = 30,
                            ValueType = typeof(string),
                            CellTemplate = new DataGridViewTextBoxCell()
                        };
                        dataGridViewHorariosDisponibles.Columns.Add(mColumna);
                    }
                    for (int i = 0; i < 24; i++)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        dataGridViewHorariosDisponibles.Rows.Add(fila);
                        dataGridViewHorariosDisponibles.Rows[i].HeaderCell.Value = (i).ToString();
                        
                    }
                    //DGV Rangos Horarios Seleccionados
                    dataGridViewHorariosDisponibles.AutoGenerateColumns = false;
                    dataGridViewHorariosDisponibles.AutoSize = false;


                    Dictionary<string, List<Campania>> mDiccionario = iFachada.AvailableTimes(dateTimePickerCampaniaFechaInicio.Value, dateTimePickerCampaniaFechaFin.Value);
                    List<Campania> mListaCampaniasMenoresIguales = new List<Campania>();
                    mListaCampaniasMenoresIguales = mDiccionario["MenoresIguales"];
                    List<Campania> mListaCampaniasIntermedias = new List<Campania>();
                    mListaCampaniasIntermedias = mDiccionario["Intermedias"];
                    List<Campania> mListaCampaniasMayores = new List<Campania>();
                    mListaCampaniasMayores = mDiccionario["Mayores"];


                    //List<Campania> mListaTodasLasCampanias = iFachada.GetAllCampania().ToList();

                    //Opción 1: 
                    //List<Campania> mListaCampaniasMenoresIguales = mListaTodasLasCampanias.Where(x => (x.FechaFin <= mFechaFin) && (x.FechaFin >= mFechaInicio)).ToList();
                    int mCantidadDias = 0;
                    foreach (Campania mCampania in mListaCampaniasMenoresIguales)
                    {
                        if (mCampania.FechaInicio < mFechaInicio)
                        {
                            mCantidadDias = (mCampania.FechaFin.Date - mFechaInicio.Date).Days;
                            for (int i = 0; i <= mCantidadDias; i++)
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }
                        }
                        else
                        {
                            mCantidadDias = (mCampania.FechaFin.Date - mCampania.FechaInicio.Date).Days;
                            int mDiaInicio = (mCampania.FechaInicio.Date - mFechaInicio.Date).Days;
                            mCantidadDias = mCantidadDias + mDiaInicio;
                            for (int i = mDiaInicio; i <= mCantidadDias; i++)
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }
                        }
                    }

                    //Opción 2:
                    //List<Campania> mListaCampaniasIntermedias = mListaTodasLasCampanias.Where(x => (x.FechaFin > mFechaFin) && (x.FechaInicio <= mFechaFin) && (x.FechaInicio >= mFechaInicio)).ToList();
                    foreach (Campania mCampania in mListaCampaniasIntermedias)
                    {
                        mCantidadDias = (mCampania.FechaInicio.Date - mFechaInicio.Date).Days;
                        
                        for (int i = mCantidadDias; i <= mCantidadColumnas; i++)
                        {
                            for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                            }

                        }
                    }

                    //Opción 3:
                    //List<Campania> mListaCampaniasMayores = mListaTodasLasCampanias.Where(x => (x.FechaInicio < mFechaInicio) && (x.FechaFin > mFechaFin)).ToList();
                    foreach (Campania mCampania in mListaCampaniasMayores)
                    {
                        for (int i = 0; i <= mCantidadColumnas; i++)
                        {
                            for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                            }
                        }

                            
                    }
                }
                else
                {
                    MessageBox.Show("La fecha de inicio debe ser menor a la fecha fin");
                }
            }
            else
            {
                MessageBox.Show("La fecha de inicio ya ha pasado");
            }
        }


        private void btnCampaniaGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificar si la hora seleccionada está disponible..
                Dictionary<string, List<Campania>> mDiccionario = iFachada.AvailableTimes(dateTimePickerCampaniaFechaInicio.Value, dateTimePickerCampaniaFechaFin.Value);
                List<Campania> mListaCampaniasMenoresIguales = new List<Campania>();
                mListaCampaniasMenoresIguales = mDiccionario["MenoresIguales"];
                List<Campania> mListaCampaniasIntermedias = new List<Campania>();
                mListaCampaniasIntermedias = mDiccionario["Intermedias"];
                List<Campania> mListaCampaniasMayores = new List<Campania>();
                mListaCampaniasMayores = mDiccionario["Mayores"];
                //OP 1
                foreach (Campania mItemCampania in mListaCampaniasMenoresIguales)
                {
                    //if(mItemCampania.FechaFin.Hour )
                }
                //OP 2
                //OP 3




                    if (textBoxCampaniaNombre.Text == "")
                {
                    throw new Exception("Falta ingresar el nombre de la campaña");
                }

                if ((Convert.ToInt32(comboBoxCampaniHoraInicio.Text) < 0) || 
                    (Convert.ToInt32(comboBoxCampaniHoraInicio.Text) > 23))
                {
                    throw new Exception("La hora de inicio ingresada no es válida");
                }

                if ((Convert.ToInt32(comboBoxCampaniaHoraFin.Text) < 0) || 
                    (Convert.ToInt32(comboBoxCampaniaHoraFin.Text) > 23))
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
                MessageBox.Show("La campaña se ha guardado con éxito");
                this.Close();

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
