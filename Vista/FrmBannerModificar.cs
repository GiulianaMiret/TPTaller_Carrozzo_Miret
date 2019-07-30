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
    public partial class FrmBannerModificar : Form
    {
        private readonly Fachada cFachada;
        private readonly Logger.ILogger cLogger;
        private Banner cBanner;

        public FrmBannerModificar(Fachada fachada, Logger.ILogger logger)
        {
            cFachada = fachada;
            cLogger = logger;
            InitializeComponent();
        }

        private void FrmBannerModificar_Load(object sender, EventArgs e)
        {
            dataGridViewBanners.DataSource = cFachada.GetAllBanner();
            dataGridViewFuentes.DataSource = cFachada.GetAllRSS();
            comboBoxTipoFuente.Text = "RSS";
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Banner> mListaResultadoBusqueda = new List<Banner>();
            if (textBoxNombreBanner.Text != "")
            {
                mListaResultadoBusqueda = cFachada.GetAllBanner().Where(x => x.Nombre.ToLower().Contains(textBoxNombreBanner.Text.ToLower())).ToList();
                dataGridViewBanners.DataSource = mListaResultadoBusqueda;
            }
            else
            {
                mListaResultadoBusqueda = cFachada.GetAllBanner();
            }
            dataGridViewBanners.DataSource = mListaResultadoBusqueda;
        }

        private void buttonConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            dataGridViewHorariosDisponibles.Columns.Clear();
            dataGridViewHorariosDisponibles.Visible = true;
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
                //DGV Rangos Horarios Seleccionados
                dataGridViewHorariosDisponibles.AutoGenerateColumns = false;
                dataGridViewHorariosDisponibles.AutoSize = false;

                Dictionary<string, List<Banner>> mDiccionario = cFachada.AvailableTimesBanner(dateTimePickerBannerFechaInicio.Value, dateTimePickerBannerFechaFin.Value);
                List<Banner> mListaBannersMenoresIguales = new List<Banner>();
                mListaBannersMenoresIguales = mDiccionario["MenoresIguales"];
                List<Banner> mListaBannersIntermedias = new List<Banner>();
                mListaBannersIntermedias = mDiccionario["Intermedias"];
                List<Banner> mListaBannersMayores = new List<Banner>();
                mListaBannersMayores = mDiccionario["Mayores"];

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
                cLogger.Debug("Se consultó la disponibilidad horaria para Modificar Banner");
            }
            else
            {
                MessageBox.Show("La fecha de inicio debe ser menor a la fecha fin");
            }

        }

        private void comboBoxTipoFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoFuente.Text == "RSS")
            {
                dataGridViewFuentes.DataSource = cFachada.GetAllRSS().ToList();
                dataGridViewFuentes.Columns["URL"].Visible = false;
            }
            else
            {
                dataGridViewFuentes.DataSource = cFachada.GetAllTXT().ToList();
            }
        }

        private void buttonSeleccionarFuente_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuentes.CurrentRow.Index != -1)
            {

                if (comboBoxTipoFuente.Text == "RSS")
                {
                    FuenteRSS mFuente = new FuenteRSS { Id = Convert.ToInt32(dataGridViewFuentes["Id", dataGridViewFuentes.CurrentRow.Index].Value) };
                    mFuente = cFachada.GetFuenteRSS(mFuente);
                    textBoxTituloFuente.Text = mFuente.Titulo;
                    textBoxValorFuente.Text = mFuente.Valor;
                    textBoxId.Text = mFuente.Id.ToString();
                }
                else
                {
                    FuenteTextoFijo mFuente = new FuenteTextoFijo { Id = Convert.ToInt32(dataGridViewFuentes["Id", dataGridViewFuentes.CurrentRow.Index].Value) };
                    mFuente = cFachada.GetFuenteTXT(mFuente);
                    textBoxTituloFuente.Text = mFuente.Titulo;
                    textBoxValorFuente.Text = mFuente.Valor;
                    textBoxId.Text = mFuente.Id.ToString();
                }
            }

        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            if (dataGridViewBanners.CurrentRow.Index != -1)
            {
                Banner mBanner = new Banner { Id = Convert.ToInt32(dataGridViewBanners["Id_Banner", dataGridViewBanners.CurrentRow.Index].Value) };
                cBanner = cFachada.GetBanner(mBanner);

                textBoxNombreBanner.Text = cBanner.Nombre;
                dateTimePickerBannerFechaInicio.Value = cBanner.FechaInicio.Date;
                dateTimePickerBannerFechaFin.Value = cBanner.FechaFin.Date;
                comboBoxHoraInicioBanner.Text = ((cBanner.FechaInicio.Hour).ToString());
                comboBoxHoraFinBanner.Text = ((cBanner.FechaFin.Hour).ToString());
                textBoxTituloFuente.Text = cBanner.Fuente.Titulo;
                textBoxValorFuente.Text = cBanner.Fuente.Valor;
                textBoxId.Text = cBanner.Fuente.Id.ToString();

                var tipo = cBanner.Fuente.GetType();
                if(tipo.Name == "FuenteRSS")
                {
                    comboBoxTipoFuente.Text = "RSS";
                    dataGridViewFuentes.DataSource = cFachada.GetAllRSS();
                }
                else
                {
                    comboBoxTipoFuente.Text = "Texto Fijo";
                    dataGridViewFuentes.DataSource = cFachada.GetAllTXT();
                }
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBanner != null)
                {
                    //Verifia si tiene nombre
                    if (textBoxNombreBanner.Text == "")
                    {
                        throw new Exception("Falta ingresar el nombre del Banner");
                    }

                    //Verifica si la hora de inicio está en el rango aceptado
                    if ((Convert.ToInt32(comboBoxHoraInicioBanner.Text) < 0) ||
                        (Convert.ToInt32(comboBoxHoraInicioBanner.Text) > 23))
                    {
                        throw new Exception("La hora de inicio ingresada no es válida");
                    }

                    //Verifica si la hora de fin está en el rango aceptado
                    if ((Convert.ToInt32(comboBoxHoraFinBanner.Text) < 0) ||
                        (Convert.ToInt32(comboBoxHoraFinBanner.Text) > 23))
                    {
                        throw new Exception("La hora de fin ingresada no es válida");
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

                    //Pasa la info del datePicker y el combo a una sola variable
                    DateTime mFechaInicio = new DateTime(
                                                        dateTimePickerBannerFechaInicio.Value.Year,
                                                        dateTimePickerBannerFechaInicio.Value.Month,
                                                        dateTimePickerBannerFechaInicio.Value.Day,
                                                        Convert.ToInt32(comboBoxHoraInicioBanner.Text),
                                                        0,
                                                        0);
                    DateTime mFechaFin = new DateTime(
                                                     dateTimePickerBannerFechaFin.Value.Year,
                                                     dateTimePickerBannerFechaFin.Value.Month,
                                                     dateTimePickerBannerFechaFin.Value.Day,
                                                     Convert.ToInt32(comboBoxHoraFinBanner.Text),
                                                     0,
                                                     0);

                    Banner mBanner = new Banner();
                    mBanner.Id = cBanner.Id;
                    mBanner.FechaInicio = cBanner.FechaInicio;
                    mBanner.FechaFin = cBanner.FechaFin;
                    //Verifica si la hora seleccionada está disponible
                    Dictionary<string, List<Banner>> mDiccionario = cFachada.AvailableTimesBanner(dateTimePickerBannerFechaInicio.Value, dateTimePickerBannerFechaFin.Value);
                    bool mDisponible = cFachada.AvailableHoursBanner(mBanner, mDiccionario);
                    if (!mDisponible)
                    {
                        throw new Exception("El horario seleccionado no está disponible");
                    }

                    cBanner.Nombre = textBoxNombreBanner.Text;
                    cBanner.FechaInicio = mFechaInicio;
                    cBanner.FechaFin = mFechaFin;

                    if (comboBoxTipoFuente.Text == "RSS")
                    {
                        FuenteRSS mFuente = new FuenteRSS { Id = Convert.ToInt32(textBoxId.Text) };
                        mFuente = cFachada.GetFuenteRSS(mFuente);
                        cBanner.Fuente = mFuente;
                    }
                    else
                    {
                        FuenteTextoFijo mFuente = new FuenteTextoFijo { Id = Convert.ToInt32(textBoxId.Text) };
                        mFuente = cFachada.GetFuenteTXT(mFuente);
                        cBanner.Fuente = mFuente;
                    }
                    DialogResult mMessageBoxResultado = MessageBox.Show("¿Desea modificar el Banner?", "Modificar Banner", MessageBoxButtons.YesNo);
                    if (mMessageBoxResultado == DialogResult.Yes)
                    {
                        cFachada.UpdateBanner(cBanner);
                        MessageBox.Show("El Banner se ha modificado con éxito");
                        dataGridViewBanners.DataSource = cFachada.GetAllBanner();
                        string mCadena = "Se modificó el Banner: Id: " + mBanner.Id + " Nombre: " + mBanner.Nombre + " Fecha y Hora de inicio: " + mBanner.FechaInicio + " Fecha y Hora de fin: " + mBanner.FechaFin + " Y la fuente; " + mBanner.Fuente.Titulo;
                        cLogger.Debug(mCadena);
                    }
                }
                else
                {
                    throw new Exception("No hay modificaciones para guardar");
                }
            }
            catch (Exception mExcepcion)
            {
                MessageBox.Show(mExcepcion.Message);
                cLogger.Debug(mExcepcion.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
