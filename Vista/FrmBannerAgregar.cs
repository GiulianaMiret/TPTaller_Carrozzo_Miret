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

namespace Vista
{
    public partial class FrmBannerAgregar : Form
    {
        private readonly Fachada cFachada;
        private readonly Logger.ILogger cLogger;

        public FrmBannerAgregar(Fachada fachada, Logger.ILogger logger)
        {
            cFachada = fachada;
            cLogger = logger;
            InitializeComponent();
        }

        private void FrmBannerAgregar_Load(object sender, EventArgs e)
        {
            comboBoxTipoFuente.Text = "RSS";
            //Trae todas las fuentes de tipo RSS de la base de datos
            List<FuenteRSS> mListaFuenteRSS = cFachada.GetAllRSS().ToList();
            dataGridViewFuentes.DataSource = mListaFuenteRSS;
            
        }

        /// <summary>
        /// Busca todos los banner que se encuentran dentro del rango de fechas establecido y crea un datagridview
        /// marcando con rojo las horas no disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            dataGridViewHorariosDisponibles.Columns.Clear();
            dataGridViewHorariosDisponibles.Visible = true;
            //Crea las filas y columnas del datagrid que se muestra en pantalla
            if (dateTimePickerBannerFechaInicio.Value.Date >= DateTime.Now.Date)
            {
                if (dateTimePickerBannerFechaInicio.Value.Date <= dateTimePickerBannerFechaFin.Value.Date)
                {
                    DateTime mFechaInicio = dateTimePickerBannerFechaInicio.Value;
                    DateTime mFechaFin = dateTimePickerBannerFechaFin.Value;
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
                    dataGridViewHorariosDisponibles.AutoGenerateColumns = false;
                    dataGridViewHorariosDisponibles.AutoSize = false;

                    //Trae todas los los banners que se encuentran entre las fechas ingresadas
                    Dictionary<string, List<Banner>> mDiccionario = cFachada.AvailableTimesBanner(dateTimePickerBannerFechaInicio.Value, dateTimePickerBannerFechaFin.Value);
                    List<Banner> mListaBannersMenoresIguales = new List<Banner>();
                    mListaBannersMenoresIguales = mDiccionario["MenoresIguales"];
                    List<Banner> mListaBannersIntermedias = new List<Banner>();
                    mListaBannersIntermedias = mDiccionario["Intermedias"];
                    List<Banner> mListaBannersMayores = new List<Banner>();
                    mListaBannersMayores = mDiccionario["Mayores"];
                    //Completa el datagrid con el color rojo en los horarios donde hay un banner
                    //Opción 1: 
                    int mCantidadDias = 0;
                    foreach (Banner mBanner in mListaBannersMenoresIguales)
                    {
                        if (mBanner.FechaInicio < mFechaInicio)
                        {
                            mCantidadDias = (mBanner.FechaFin.Date - mFechaInicio.Date).Days;
                            for (int i = 0; i <= mCantidadDias; i++)
                            {
                                if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                                {
                                    for (int j = (mBanner.FechaInicio.Hour); j < 24; j++)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                    }
                                    for (int j = 0; j <= (mBanner.FechaFin.Hour); j++)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    for (int j = (mBanner.FechaInicio.Hour); j <= (mBanner.FechaFin.Hour); j++)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                        else
                        {
                            mCantidadDias = (mBanner.FechaFin.Date - mBanner.FechaInicio.Date).Days;
                            int mDiaInicio = (mBanner.FechaInicio.Date - mFechaInicio.Date).Days;
                            mCantidadDias = mCantidadDias + mDiaInicio;
                            for (int i = mDiaInicio; i <= mCantidadDias; i++)
                            {
                                if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                                {
                                    for (int j = (mBanner.FechaInicio.Hour); j < 24; j++)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                    }
                                    for (int j = 0; j <= (mBanner.FechaFin.Hour); j++)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    for (int j = (mBanner.FechaInicio.Hour); j <= (mBanner.FechaFin.Hour); j++)
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
                    foreach (Banner mBanner in mListaBannersIntermedias)
                    {
                        mCantidadDias = (mBanner.FechaInicio.Date - mFechaInicio.Date).Days;

                        for (int i = mCantidadDias; i <= mCantidadColumnas; i++)
                        {
                            if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                            {
                                for (int j = (mBanner.FechaInicio.Hour); j < 24; j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                                for (int j = 0; j <= (mBanner.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                for (int j = (mBanner.FechaInicio.Hour); j <= (mBanner.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }

                        }
                    }

                    //Opción 3:
                    foreach (Banner mBanner in mListaBannersMayores)
                    {
                        for (int i = 0; i <= mCantidadColumnas; i++)
                        {
                            if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                            {
                                for (int j = (mBanner.FechaInicio.Hour); j < 24; j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                                for (int j = 0; j <= (mBanner.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                for (int j = (mBanner.FechaInicio.Hour); j <= (mBanner.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = Color.Red;
                                }
                            }
                        }
                    }
                    cLogger.Debug("Se consultó la disponibilidad horaria para Agregar Banner");
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

        /// <summary>
        /// Carga todos los datos de la fuente seleccionada en sus correspondientes componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeleccionarFuente_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuentes.CurrentRow.Index != -1)
            {
                if(comboBoxTipoFuente.Text == "RSS")
                {
                    FuenteRSS mFuente = new FuenteRSS { Id = Convert.ToInt32(dataGridViewFuentes["Id", dataGridViewFuentes.CurrentRow.Index].Value) };
                    mFuente = cFachada.GetFuenteRSS(mFuente);
                    textBoxTituloFuente.Text = mFuente.Titulo;
                    textBoxValorFuente.Text = mFuente.Valor;
                    textBoxId.Text = mFuente.Id.ToString();
                }
                else
                {
                    FuenteTextoFijo mFuente = new FuenteTextoFijo{ Id = Convert.ToInt32(dataGridViewFuentes["Id", dataGridViewFuentes.CurrentRow.Index].Value) };
                    mFuente = cFachada.GetFuenteTXT(mFuente);
                    textBoxTituloFuente.Text = mFuente.Titulo;
                    textBoxValorFuente.Text = mFuente.Valor;
                    textBoxId.Text = mFuente.Id.ToString();
                }
            }
        }

        /// <summary>
        /// Cambia las fuentes mostradas en el datagrid cuando se selecciona un tipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTipoFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTipoFuente.Text == "RSS")
            {
                dataGridViewFuentes.DataSource = cFachada.GetAllRSS().ToList();
                dataGridViewFuentes.Columns["URL"].Visible = false;
            }
            else
            {
                dataGridViewFuentes.DataSource = cFachada.GetAllTXT().ToList();
            }
        }

        /// <summary>
        /// Verifica los datos y guarda el nuevo banner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBannerGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifia si tiene nombre
                if (textBoxBannerNombre.Text == "")
                {
                    throw new Exception("Falta ingresar el nombre del Banner");
                }

                //Verifica si las fechas forman un rango aceptable
                if (dateTimePickerBannerFechaInicio.Value.Date < DateTime.Now.Date)
                {
                    throw new Exception("No se admiten Fechas de Inicios pasadas");
                }

                if (dateTimePickerBannerFechaFin.Value.Date < dateTimePickerBannerFechaInicio.Value.Date)
                {
                    throw new Exception("La Fecha Final debe ser mayor a la Fecha de Inicio");
                }

                //Verifica si se han seleccionado imágenes
                if (dataGridViewFuentes.CurrentRow.Index < 0)
                {
                    throw new Exception("Debe seleccionar al menos una fuente");
                }

                //Pasa la info del datePicker y el combo a una sola variable
                DateTime mFechaInicio = new DateTime(
                                                    dateTimePickerBannerFechaInicio.Value.Year,
                                                    dateTimePickerBannerFechaInicio.Value.Month,
                                                    dateTimePickerBannerFechaInicio.Value.Day,
                                                    Convert.ToInt32(comboBoxBannerHoraInicio.Text),
                                                    0,
                                                    0);
                DateTime mFechaFin = new DateTime(
                                                 dateTimePickerBannerFechaFin.Value.Year,
                                                 dateTimePickerBannerFechaFin.Value.Month,
                                                 dateTimePickerBannerFechaFin.Value.Day,
                                                 Convert.ToInt32(comboBoxBannerHoraFin.Text),
                                                 0,
                                                 0);

                Banner mBanner = new Banner();
                mBanner.Nombre = textBoxBannerNombre.Text;
                mBanner.FechaInicio = mFechaInicio;
                mBanner.FechaFin = mFechaFin;

                //Verifica si la hora seleccionada está disponible
                Dictionary<string, List<Banner>> mDiccionario = cFachada.AvailableTimesBanner(dateTimePickerBannerFechaInicio.Value, dateTimePickerBannerFechaFin.Value);
                bool mDisponible = cFachada.AvailableHoursBanner(mBanner, mDiccionario);
                if (!mDisponible)
                {
                    throw new Exception("El horario seleccionado no está disponible");
                }

                if (comboBoxTipoFuente.Text == "RSS")
                {
                    FuenteRSS mFuente = new FuenteRSS { Id = Convert.ToInt32(textBoxId.Text)};
                    mFuente = cFachada.GetFuenteRSS(mFuente);
                    mBanner.Fuente = mFuente;
                }
                else
                {
                    FuenteTextoFijo mFuente = new FuenteTextoFijo { Id = Convert.ToInt32(textBoxId.Text) };
                    mFuente = cFachada.GetFuenteTXT(mFuente);
                    mBanner.Fuente = mFuente;
                }
                string mCadena = "Se agregó el Banner: Id " + mBanner.Id + ", Nombre: " + mBanner.Nombre + ", Fecha y Hora de inicio: " + mBanner.FechaInicio + ", Fecha y Hora de fin: " + mBanner.FechaFin + " Y la Fuente: " + mBanner.Fuente.Titulo;
                cLogger.Debug(mCadena);
                cFachada.AddBanner(mBanner);
                MessageBox.Show("El Banner se ha guardado con éxito");
            }
            catch (Exception mExcepcion)
            {
                MessageBox.Show(mExcepcion.Message);
                cLogger.Debug(mExcepcion.Message);
            }

        }


        private void btnBannerCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
