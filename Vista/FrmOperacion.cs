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
using Vista.Logger;
using System.Threading;

namespace Vista
{
    public partial class FrmOperacion : Form
    {
        private readonly Fachada cFachada;
        private readonly ILogger cLogger;
        private List<Imagen> cListaImagenes;
        private int cIndice;

        public FrmOperacion(Fachada pFachada, ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            cIndice = 0;
            InitializeComponent();
            cListaImagenes = new List<Imagen>();
        }

        //Inicia los timers del banner y la campaña
        private void FrmOperacion_Load(object sender, EventArgs e)
        {
            timerBanner.Start();
            timerCampaña.Start();
        }

        /// <summary>
        /// Busca la campaña actual y modifica el valor del timerCampaña para la próxima búsqueda
        /// </summary>
        /// <returns>Campaña</returns>
        private Campania obtenerCampania()
        {
            Campania mCampania = cFachada.GetCampaniaNow();
            int mHoraTimer = DateTime.Now.AddHours(1).Hour;
            mHoraTimer = (60 - DateTime.Now.Minute);
            //timerCampaña.Interval = mHoraTimer * 60000;
            return mCampania;
        }

        /// <summary>
        /// Busca el banner actual y modifica el valor del timerBanner para realizar la proxima busqueda
        /// </summary>
        /// <returns></returns>
        private Banner obtenerBanner()
        {
            Banner mBanner = cFachada.GetBannerNow();
            if(mBanner != null)
            {
                mBanner.Fuente.Actualizar();
            }
            int mHoraTimer = DateTime.Now.AddHours(1).Hour;
            mHoraTimer = (60 - DateTime.Now.Minute);
            timerBanner.Interval = mHoraTimer * 60000;
            return mBanner;
        }

        /// <summary>
        /// Mueve el label del banner en la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerLabelBanner_Tick(object sender, EventArgs e)
        {
            this.lblBanner.Left -= 5;
            if (lblBanner.Right <= 0)
            {
                lblBanner.Left = Width;
            }
        }

        /// <summary>
        /// Cada hora verifica si se debe cambiar el texto del banner mostrado en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBanner_Tick(object sender, EventArgs e)
        {
            timerBanner.Stop();
            Banner mBanner = obtenerBanner();
            if (mBanner != null)
            {
                lblBanner.Text = mBanner.Fuente.Valor;
            }
            else
            {
                lblBanner.Text = "Publicite gratis en Shout News! Llame al 03442 412345 y contáctese con nosotros";
            }
            timerBanner.Start();
            timerLabelBanner.Start();
        }

        /// <summary>
        /// Cada una hora, verifica las imágenes que se tienen que mostrar en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCampaña_Tick(object sender, EventArgs e)
        {
            timerCampaña.Stop();
            Campania mCampania = obtenerCampania();
            if (mCampania != null)
            {
                cListaImagenes = mCampania.Imagenes.ToList();
            }
            else
            {
                cListaImagenes = null;
                if(pictureBoxOperacion.Image != null)
                {
                    pictureBoxOperacion.Image.Dispose();
                }
                
            }
            timerCampaña.Start();
            timerPictureBoxCampaña.Start();
        }

        /// <summary>
        /// Cambia las imagenes de la campaña acutal en la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPictureBoxCampaña_Tick(object sender, EventArgs e)
        {
            if(cListaImagenes != null)
            {
                if (cIndice >= cListaImagenes.Count())
                {
                    cIndice = 0;
                }
                this.pictureBoxOperacion.Image = cFachada.ByteToImage(cListaImagenes[cIndice].Hash);
                this.pictureBoxOperacion.SizeMode = PictureBoxSizeMode.StretchImage;
                cIndice++;
            }
        }

        /// <summary>
        /// Detiene todos los timers cuando se cierra la pantalla de operaciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmOperacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerBanner.Stop();
            timerCampaña.Stop();
            timerLabelBanner.Stop();
            timerPictureBoxCampaña.Stop();
        }
    }
}
