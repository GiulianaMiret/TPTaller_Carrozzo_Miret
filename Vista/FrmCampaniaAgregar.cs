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
        private readonly Fachada cFachada;
        private readonly Logger.ILogger cLogger;
        private List<string> cImagenesSeleccionadas = new List<string>();

        public FrmCampaniaAgregar(Fachada fachada, Logger.ILogger logger)
        {
            cFachada = fachada;
            cLogger = logger;
            InitializeComponent();
        }

        private void FrmAgregarCampania_Load(object sender, EventArgs e)
        {
            IList<string> mListaNombres = cFachada.GetAllNamesFromImages();
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
                    Imagen mImagen = cFachada.GetImagenByName(mNombreImagen);
                    pictureBoxVistaPreviaImagenes.Image = Utilidades.ByteToImage(mImagen.Hash);
                }
            }
        }

        private void dataGridViewTodasLasImagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                Imagen mImagen = cFachada.GetImagenByName(mNombreImagen);
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

                cImagenesSeleccionadas.Add(mNombreImagen);
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

                cImagenesSeleccionadas.Remove(mNombreImagen);
            }

        }

        private void buttonConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            dataGridViewHorariosDisponibles.Columns.Clear();
            dataGridViewHorariosDisponibles.Visible = true;

            if (dateTimePickerCampaniaFechaInicio.Value.Date >= DateTime.Now.Date)
            {
                if (dateTimePickerCampaniaFechaInicio.Value.Date <= dateTimePickerCampaniaFechaFin.Value.Date)
                {
                    DateTime mFechaInicio = dateTimePickerCampaniaFechaInicio.Value;
                    DateTime mFechaFin = dateTimePickerCampaniaFechaFin.Value;
                    int mCantidadColumnas = (mFechaFin - mFechaInicio).Days;
                    DateTime mFechaAuxiliar = new DateTime();
                    mFechaAuxiliar = mFechaInicio;

                    for (int i = 0; i <= mCantidadColumnas; i++)
                    {
                        DataGridViewColumn mColumna = new DataGridViewColumn()
                        {
                            Name = ((mFechaAuxiliar.Day).ToString() + "/" + (mFechaAuxiliar.Month).ToString()),
                            Width = 40,
                            ValueType = typeof(string),
                            CellTemplate = new DataGridViewTextBoxCell()
                        };
                        dataGridViewHorariosDisponibles.Columns.Add(mColumna);
                        mFechaAuxiliar = mFechaAuxiliar.AddDays(1);
                    }
                    for (int i = 0; i < 24; i++)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        dataGridViewHorariosDisponibles.Rows.Add(fila);
                        dataGridViewHorariosDisponibles.Rows[i].HeaderCell.Value = ((i).ToString() + " hs.");
                        dataGridViewHorariosDisponibles.AutoResizeRowHeadersWidth(
                                                        DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                    }
                    //DGV Rangos Horarios Seleccionados
                    dataGridViewHorariosDisponibles.AutoGenerateColumns = false;
                    dataGridViewHorariosDisponibles.AutoSize = false;


                    Dictionary<string, List<Campania>> mDiccionario = cFachada.AvailableTimes(dateTimePickerCampaniaFechaInicio.Value, dateTimePickerCampaniaFechaFin.Value);
                    List<Campania> mListaCampaniasMenoresIguales = new List<Campania>();
                    mListaCampaniasMenoresIguales = mDiccionario["MenoresIguales"];
                    List<Campania> mListaCampaniasIntermedias = new List<Campania>();
                    mListaCampaniasIntermedias = mDiccionario["Intermedias"];
                    List<Campania> mListaCampaniasMayores = new List<Campania>();
                    mListaCampaniasMayores = mDiccionario["Mayores"];

                    //Opción 1: 
                    int mCantidadDias = 0;
                    foreach (Campania mCampania in mListaCampaniasMenoresIguales)
                    {
                        if (mCampania.FechaInicio < mFechaInicio)
                        {
                            mCantidadDias = (mCampania.FechaFin.Date - mFechaInicio.Date).Days;
                            for (int i = 0; i < mCantidadDias; i++)
                            {
                                if(mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                                {
                                    for (int j = (mCampania.FechaInicio.Hour); j < 24; j++)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                    }
                                    for (int j = 0; j <= (mCampania.FechaFin.Hour); j++)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                    }
                                }
                                else
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
                            mCantidadDias = (mCampania.FechaFin.Date - mCampania.FechaInicio.Date).Days;
                            int mDiaInicio = (mCampania.FechaInicio.Date - mFechaInicio.Date).Days;
                            mCantidadDias = mCantidadDias + mDiaInicio;
                            for (int i = mDiaInicio; i <= mCantidadDias; i++)
                            {
                                if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                                {
                                    for (int j = (mCampania.FechaInicio.Hour); j < 24; j++)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                    }
                                    for (int j = 0; j <= (mCampania.FechaFin.Hour); j++)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                                    {
                                        if (i < dataGridViewHorariosDisponibles.ColumnCount)
                                        {
                                            dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    //Opción 2:
                    foreach (Campania mCampania in mListaCampaniasIntermedias)
                    {
                        mCantidadDias = (mCampania.FechaInicio.Date - mFechaInicio.Date).Days;
                        
                        for (int i = mCantidadDias; i <= mCantidadColumnas; i++)
                        {
                            if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j < 24; j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                                for (int j = 0; j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }
                        }
                    }

                    //Opción 3:
                    foreach (Campania mCampania in mListaCampaniasMayores)
                    {
                        for (int i = 0; i <= mCantidadColumnas; i++)
                        {
                            if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j < 24; j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                                for (int j = 0; j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }
                        }
                    }
                    cLogger.Debug("Se consltó la disponibilidad horaria para Agregar Campaña");
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
                //Verifia si tiene nombre
                if (textBoxCampaniaNombre.Text == "")
                {
                    throw new Exception("Falta ingresar el nombre de la campaña");
                }

                //Verifica si la hora de inicio está en el rango aceptado
                if ((Convert.ToInt32(comboBoxCampaniHoraInicio.Text) < 0) ||
                    (Convert.ToInt32(comboBoxCampaniHoraInicio.Text) > 23))
                {
                    throw new Exception("La hora de inicio ingresada no es válida");
                }

                //Verifica si la hora de fin está en el rango aceptado
                if ((Convert.ToInt32(comboBoxCampaniaHoraFin.Text) < 0) ||
                    (Convert.ToInt32(comboBoxCampaniaHoraFin.Text) > 23))
                {
                    throw new Exception("La hora de fin ingresada no es válida");
                }

                //Verifica si las fechas forman un rango aceptable
                if (dateTimePickerCampaniaFechaInicio.Value.Date < DateTime.Now.Date)
                {
                    throw new Exception("No se admiten Fechas de Inicios pasadas");
                }

                if (dateTimePickerCampaniaFechaFin.Value.Date < dateTimePickerCampaniaFechaInicio.Value.Date)
                {
                    throw new Exception("La Fecha Final debe ser mayor a la Fecha de Inicio");
                }

                //Verifica si se han seleccionado imágenes
                if (cImagenesSeleccionadas == null)
                {
                    throw new Exception("Debe seleccionar al menos una imágen");
                }

                //Pasa la info del datePicker y el combo a una sola variable
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

                Campania mCampania = new Campania();
                mCampania.Nombre = textBoxCampaniaNombre.Text;
                mCampania.FechaInicio = mFechaInicio;
                mCampania.FechaFin = mFechaFin;

                //Verifica si la hora seleccionada está disponible
                Dictionary<string, List<Campania>> mDiccionario = cFachada.AvailableTimes(dateTimePickerCampaniaFechaInicio.Value, dateTimePickerCampaniaFechaFin.Value);
                bool mDisponible = cFachada.AvailableHoursCampania(mCampania, mDiccionario);
                if (!mDisponible)
                {
                    throw new Exception("El horario seleccionado no está disponible");
                }

                List<Imagen> mListaImagenes = new List<Imagen>();

                foreach (string mNombreImagen in cImagenesSeleccionadas)
                {
                    Imagen mImagen = cFachada.GetImagenByName(mNombreImagen);
                    mListaImagenes.Add(mImagen);
                }
                mCampania.Imagenes = mListaImagenes;
                string mCadena = "Se agregó la campaña: Id " + mCampania.Id + ", Nombre: " + mCampania.Nombre + ", Fecha y Hora de inicio: " + mCampania.FechaInicio + ", Fecha y Hora de fin: " + mCampania.FechaFin + " Y las imágenes: ";
                foreach (string mNombreImagen in cImagenesSeleccionadas)
                {
                    mCadena = mCadena.ToString() + mNombreImagen + " - ";
                }
                cLogger.Debug(mCadena);
                cFachada.AddCampania(mCampania);
                MessageBox.Show("La campaña se ha guardado con éxito");
                this.Close();
            }
            catch (Exception mExcepcion)
            {
                MessageBox.Show(mExcepcion.Message);
                cLogger.Debug(mExcepcion.Message);
            }
        }


        private void btnCampaniaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
