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

        /// <summary>
        /// Cuando inicia la pestaña, se buscan todos los nombres de las imagenes que estan en la base de datos
        /// y se los lista en un datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    pictureBoxVistaPreviaImagenes.Image = cFachada.ByteToImage(mImagen.Hash);
                }
            }
        }

        /// <summary>
        /// Cada vez que se selecciona una celda del datagridview, se muestra la imagen en el picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTodasLasImagenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
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
            if(dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value != null)
            {
                //busca la imagen seleccionada
                string mNombreImagen = dataGridViewTodasLasImagenes.CurrentRow.Cells[0].Value.ToString();
                //Agrega al datagridview
                dataGridViewImagenesSeleccionadas.Rows.Add(mNombreImagen);
                dataGridViewImagenesSeleccionadas.Show();
                //Quita del otro datagridview
                dataGridViewTodasLasImagenes.Rows.Remove(dataGridViewTodasLasImagenes.CurrentRow);
                dataGridViewTodasLasImagenes.Show();
                //Agrega la imagen a la lista de imagenes que va a tener la campaña
                cImagenesSeleccionadas.Add(mNombreImagen);
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
                //Busca la imagen seleccionada
                string mNombreImagen = dataGridViewImagenesSeleccionadas.CurrentRow.Cells[0].Value.ToString();
                //agrega la imagen al datagridview donde estan todas las imagenes de la base de datos
                dataGridViewTodasLasImagenes.Rows.Add(mNombreImagen);
                dataGridViewTodasLasImagenes.Show();
                //Quita la imagen del datagridview de imagenes para la campaña
                dataGridViewImagenesSeleccionadas.Rows.Remove(dataGridViewImagenesSeleccionadas.CurrentRow);
                dataGridViewImagenesSeleccionadas.Show();
                //Quita la imagen de la lista de imagenes de la campaña
                cImagenesSeleccionadas.Remove(mNombreImagen);
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

            if (dateTimePickerCampaniaFechaInicio.Value.Date >= DateTime.Now.Date)
            {
                //Crea el datagridview que se mostrará
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
                    dataGridViewHorariosDisponibles.AutoGenerateColumns = false;
                    dataGridViewHorariosDisponibles.AutoSize = false;

                    //Toma todas las campañas que se encuentran dentro de los dias indicados
                    Dictionary<string, List<Campania>> mDiccionario = cFachada.AvailableTimes(dateTimePickerCampaniaFechaInicio.Value, dateTimePickerCampaniaFechaFin.Value);
                    List<Campania> mListaCampaniasMenoresIguales = new List<Campania>();
                    mListaCampaniasMenoresIguales = mDiccionario["MenoresIguales"];
                    List<Campania> mListaCampaniasIntermedias = new List<Campania>();
                    mListaCampaniasIntermedias = mDiccionario["Intermedias"];
                    List<Campania> mListaCampaniasMayores = new List<Campania>();
                    mListaCampaniasMayores = mDiccionario["Mayores"];
                    //completa el datagridview con el color rojo en los horarios ocupados
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

        /// <summary>
        /// Verifica los datos y guarda la nueva campaña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                //Busca todas las imagenes seleccionadas por nombres y las agrega a la campaña
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
