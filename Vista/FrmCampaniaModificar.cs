﻿using System;
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
    public partial class FrmCampaniaModificar : Form
    {
        private readonly Fachada cFachada;
        private readonly Logger.ILogger cLogger;
        private List<string> cImagenesSeleccionadas = new List<string>();
        private Campania cCampania;

        public FrmCampaniaModificar(Fachada fachada, Logger.ILogger logger)
        {
            cFachada = fachada;
            cLogger = logger;
            InitializeComponent();
        }

        /// <summary>
        /// Busca en la base de datos todas las campañas y las lista en un datagridview
        /// Busca todas las imagenes y muestra sus nombres en un datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmModificarCampania_Load(object sender, EventArgs e)
        {
            IList<string> mListaNombres = cFachada.GetAllNamesFromImages();
            foreach (string mNombre in mListaNombres)
            {
                dataGridViewTodasLasImagenes.Rows.Add(mNombre);
            }
            dataGridViewTodasLasImagenes.Show();
            if (dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                Imagen mImagen = cFachada.GetImagenByName(mNombreImagen);
                pictureBoxVistaPreviaImagenes.Image = cFachada.ByteToImage(mImagen.Hash);
            }            
            dataGridViewCampanias.DataSource = cFachada.GetAllCampania();
        }

        /// <summary>
        /// Muestra la imágen en el picturebox cada vez que se selecciona una celda del datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTodasLasImagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                Imagen mImagen = cFachada.GetImagenByName(mNombreImagen);
                pictureBoxVistaPreviaImagenes.Image = cFachada.ByteToImage(mImagen.Hash);
            }
        }

        /// <summary>
        /// Quita la imagen seleccionada del datagridview donde están todas y la agrega al datagridview 
        /// donde estan las imagenes de la campaña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
            if (dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                cImagenesSeleccionadas.Add(mNombreImagen);
                dataGridViewImagenesSeleccionadas.Rows.Add(mNombreImagen);
                dataGridViewImagenesSeleccionadas.Show();

                dataGridViewTodasLasImagenes.Rows.Remove(dataGridViewTodasLasImagenes.CurrentRow);
                dataGridViewTodasLasImagenes.Show();
            }
        }

        /// <summary>
        /// Quita la imagen seleccionada del un datagridview de imagenes de la campaña y 
        /// la agrega al datagridview donde estan todas las imagenes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuitarImagen_Click(object sender, EventArgs e)
        {
            if (dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value.ToString();
                cImagenesSeleccionadas.Remove(mNombreImagen);
                dataGridViewTodasLasImagenes.Rows.Add(mNombreImagen);
                dataGridViewTodasLasImagenes.Show();

                dataGridViewImagenesSeleccionadas.Rows.Remove(dataGridViewImagenesSeleccionadas.CurrentRow);
                dataGridViewImagenesSeleccionadas.Show();
            }
        }

        /// <summary>
        /// Muestra en el picturebox la imagen seleccionada del datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewImagenesSeleccionadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value != null)
            {
                string mNombreImagen = dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value.ToString();
                Imagen mImagen = cFachada.GetImagenByName(mNombreImagen);
                pictureBoxImagenesActuales.Image = cFachada.ByteToImage(mImagen.Hash);
            }
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
            
            if (dateTimePickerFechaInicioCampania.Value.Date <= dateTimePickerFechaFinCampania.Value.Date)
            {
                //Crea el datagridview 
                DateTime mFechaInicio = dateTimePickerFechaInicioCampania.Value;
                DateTime mFechaFin = dateTimePickerFechaFinCampania.Value;
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
                //Busca todas las campañas que estan dentro del rango de fechas establecidos
                Dictionary<string, List<Campania>> mDiccionario = cFachada.AvailableTimes(dateTimePickerFechaInicioCampania.Value, dateTimePickerFechaFinCampania.Value);
                List<Campania> mListaCampaniasMenoresIguales = new List<Campania>();
                mListaCampaniasMenoresIguales = mDiccionario["MenoresIguales"];
                List<Campania> mListaCampaniasIntermedias = new List<Campania>();
                mListaCampaniasIntermedias = mDiccionario["Intermedias"];
                List<Campania> mListaCampaniasMayores = new List<Campania>();
                mListaCampaniasMayores = mDiccionario["Mayores"];
                Color mColor = new Color();
                //Pinta las celdas del datagridview que están ocupadas por otra campaña
                //Opción 1: 
                int mCantidadDias = 0;
                foreach (Campania mCampania in mListaCampaniasMenoresIguales)
                {
                    if (mCampania.FechaInicio < mFechaInicio)
                    {
                        mCantidadDias = (mCampania.FechaFin.Date - mFechaInicio.Date).Days;
                        if(mCantidadDias <= dataGridViewHorariosDisponibles.ColumnCount)
                        {
                            mCantidadDias = mCantidadColumnas;
                        }
                        for (int i = 0; i <= mCantidadDias; i++)
                        {
                            mColor = Color.Red;
                            if (cCampania != null)
                            {
                                if (cCampania.Id == mCampania.Id)
                                {
                                    mColor = Color.Green;
                                }
                            }
                            if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j < 24; j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                                }
                                for (int j = 0; j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                                }
                            }
                            else
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                                }
                            }
                        }
                    }
                    else
                    {
                        mCantidadDias = (mCampania.FechaFin.Date - mCampania.FechaInicio.Date).Days;
                        int mDiaInicio = (mCampania.FechaInicio.Date - mFechaInicio.Date).Days;
                        mCantidadDias = mCantidadDias + mDiaInicio;
                        if (mCantidadDias <= dataGridViewHorariosDisponibles.ColumnCount)
                        {
                            mCantidadDias = mCantidadColumnas;
                        }
                        for (int i = mDiaInicio; i <= mCantidadDias; i++)
                        {
                            mColor = Color.Red;
                            if (cCampania != null)
                            {
                                if (cCampania.Id == mCampania.Id)
                                {
                                    mColor = Color.Green;
                                }
                            }
                            if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j < 24; j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                                }
                                for (int j = 0; j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                                }
                            }
                            else
                            {
                                for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                                {
                                    if (i < dataGridViewHorariosDisponibles.ColumnCount)
                                    {
                                        dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
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
                        mColor = Color.Red;
                        if (cCampania != null)
                        {
                            if (cCampania.Id == mCampania.Id)
                            {
                                mColor = Color.Green;
                            }
                        }
                        if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                        {
                            for (int j = (mCampania.FechaInicio.Hour); j < 24; j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                            }
                            for (int j = 0; j <= (mCampania.FechaFin.Hour); j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                            }
                        }
                        else
                        {
                            for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                            }
                        }

                    }
                }

                //Opción 3:
                foreach (Campania mCampania in mListaCampaniasMayores)
                {
                    for (int i = 0; i <= mCantidadColumnas; i++)
                    {
                        mColor = Color.Red;
                        if (cCampania != null)
                        {
                            if (cCampania.Id == mCampania.Id)
                            {
                                mColor = Color.Green;
                            }
                        }
                        if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                        {
                            for (int j = (mCampania.FechaInicio.Hour); j < 24; j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                            }
                            for (int j = 0; j <= (mCampania.FechaFin.Hour); j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                            }
                        }
                        else
                        {
                            for (int j = (mCampania.FechaInicio.Hour); j <= (mCampania.FechaFin.Hour); j++)
                            {
                                dataGridViewHorariosDisponibles[i, j].Style.BackColor = mColor;
                            }
                        }
                    }
                }
                cLogger.Debug("Se consultó la disponibilidad horaria para Modificar Campaña");
            }
            else
            {
                MessageBox.Show("La fecha de inicio debe ser menor a la fecha fin");
            }
        }

        /// <summary>
        /// Toma la vampaña seleccionado actualmente del datagridview y carga sus datos en los campos correspondientes
        /// incluyendo las imágenes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            dataGridViewHorariosDisponibles.Visible = false;
            dataGridViewTodasLasImagenes.Rows.Clear();
            IList<string> mListaNombres = cFachada.GetAllNamesFromImages();
            foreach (string mNombre in mListaNombres)
            {
                dataGridViewTodasLasImagenes.Rows.Add(mNombre);
            }

            cImagenesSeleccionadas = new List<string>();
            dataGridViewImagenesSeleccionadas.Rows.Clear();
            if (dataGridViewCampanias.CurrentRow.Index != -1)
            {
                dataGridViewHorariosDisponibles.Visible = false;
                Campania mCampania = new Campania { Id = Convert.ToInt32(dataGridViewCampanias["Id", dataGridViewCampanias.CurrentRow.Index].Value) };
                cCampania = cFachada.GetCampania(mCampania);

                textBoxNombreCampania.Text = cCampania.Nombre;
                dateTimePickerFechaInicioCampania.Value = cCampania.FechaInicio.Date;
                dateTimePickerFechaFinCampania.Value = cCampania.FechaFin.Date;
                comboBoxHoraInicioCampania.Text = (cCampania.FechaInicio.Hour).ToString();
                comboBoaxHoraFinCampania.Text = (cCampania.FechaFin.Hour).ToString();
                List<Imagen> mListaImagenes = cFachada.GetImagesOfCampania(cCampania);
                
                foreach (Imagen mImagen in mListaImagenes)
                {
                    cImagenesSeleccionadas.Add(mImagen.Nombre);
                    dataGridViewImagenesSeleccionadas.Rows.Add(mImagen.Nombre);

                    int mFila = dataGridViewTodasLasImagenes.Rows.Cast<DataGridViewRow>()
                        .Where(r => (string)r.Cells[0].Value == mImagen.Nombre)
                        .Select(r => r.Index).FirstOrDefault();

                    dataGridViewTodasLasImagenes.Rows.RemoveAt(mFila);
                }
            }
        }

        /// <summary>
        /// Filtra por nombre en el datagridview de todas las campañas, mostrando solo 
        /// las que coincidan con el nombre escrito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Campania> mListaResultadoBusqueda = new List<Campania>();
            if (textBoxNombreCampania.Text != "")
            {
                mListaResultadoBusqueda = cFachada.GetAllCampania().Where(x => x.Nombre.ToLower().Contains(textBoxNombreCampania.Text.ToLower())).ToList();
                dataGridViewCampanias.DataSource = mListaResultadoBusqueda;
            }
            else
            {
                mListaResultadoBusqueda = cFachada.GetAllCampania();
            }
            dataGridViewCampanias.DataSource = mListaResultadoBusqueda;
        }


        /// <summary>
        /// Verifica los datos ingresados y guarda los cambios realizados en la campaña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cCampania != null)
                {
                    //Verifia si tiene nombre
                    if (textBoxNombreCampania.Text == "")
                    {
                        throw new Exception("Falta ingresar el nombre de la campaña");
                    }
                
                    //Verifica si la hora de inicio está en el rango aceptado
                    if ((Convert.ToInt32(comboBoxHoraInicioCampania.Text) < 0) ||
                        (Convert.ToInt32(comboBoxHoraInicioCampania.Text) > 23))
                    {
                        throw new Exception("La hora de inicio ingresada no es válida");
                    }

                    //Verifica si la hora de fin está en el rango aceptado
                    if ((Convert.ToInt32(comboBoaxHoraFinCampania.Text) < 0) ||
                        (Convert.ToInt32(comboBoaxHoraFinCampania.Text) > 23))
                    {
                        throw new Exception("La hora de fin ingresada no es válida");
                    }

                    //Verifica si las fechas forman un rango aceptable
                    if (dateTimePickerFechaInicioCampania.Value.Date < DateTime.Now.Date)
                    {
                        throw new Exception("No se admiten Fechas de Inicios pasadas");
                    }

                    if (dateTimePickerFechaFinCampania.Value.Date < dateTimePickerFechaInicioCampania.Value.Date)
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
                                                        dateTimePickerFechaInicioCampania.Value.Year,
                                                        dateTimePickerFechaInicioCampania.Value.Month,
                                                        dateTimePickerFechaInicioCampania.Value.Day,
                                                        Convert.ToInt32(comboBoxHoraInicioCampania.Text),
                                                        0,
                                                        0);
                    DateTime mFechaFin = new DateTime(
                                                     dateTimePickerFechaFinCampania.Value.Year,
                                                     dateTimePickerFechaFinCampania.Value.Month,
                                                     dateTimePickerFechaFinCampania.Value.Day,
                                                     Convert.ToInt32(comboBoaxHoraFinCampania.Text),
                                                     0,
                                                     0);

                    Campania mCampania = new Campania();
                    mCampania.Id = cCampania.Id;
                    mCampania.FechaInicio = mFechaInicio;
                    mCampania.FechaFin = mFechaFin;
                    //Verifica si la hora seleccionada está disponible
                    Dictionary<string, List<Campania>> mDiccionario = cFachada.AvailableTimes(dateTimePickerFechaInicioCampania.Value, dateTimePickerFechaFinCampania.Value);
                    bool mDisponible = cFachada.AvailableHoursCampania(mCampania, mDiccionario);
                    if (!mDisponible)
                    {
                        throw new Exception("El horario seleccionado no está disponible");
                    }

                    cCampania.Nombre = textBoxNombreCampania.Text;
                    cCampania.FechaInicio = mFechaInicio;
                    cCampania.FechaFin = mFechaFin;



                    List<Imagen> mListaImagenes = new List<Imagen>();

                    foreach (string mNombreImagen in cImagenesSeleccionadas)
                    {
                        Imagen mImagen = cFachada.GetImagenByName(mNombreImagen);
                        mListaImagenes.Add(mImagen);
                    }
                    if(mListaImagenes.Count() < 1)
                    {
                        throw new Exception("No se han seleccionado imágenes");
                    }
                    cCampania.Imagenes = mListaImagenes;
                    DialogResult mMessageBoxResultado = MessageBox.Show("¿Desea modificar la Campaña?", "Modificar Campaña", MessageBoxButtons.YesNo);
                    if (mMessageBoxResultado == DialogResult.Yes)
                    {
                        string mCadena = "Se modificó la campaña: Id: " + mCampania.Id + ", Nombre: " + mCampania.Nombre + ", Fecha y Hora de inicio: " + mCampania.FechaInicio + ", Fecha y Hora de fin: " + mCampania.FechaFin + " Y las imágenes: ";
                        foreach (string mNombreImagen in cImagenesSeleccionadas)
                        {
                            mCadena = mCadena.ToString() + mNombreImagen + " - ";
                        }
                        cLogger.Debug(mCadena);
                        cFachada.UpdateCampania(cCampania);
                        MessageBox.Show("La campaña se ha modificado con éxito");
                        dataGridViewCampanias.DataSource = cFachada.GetAllCampania();
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


        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
