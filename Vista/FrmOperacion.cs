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
        private Imagen[] cListaImagenes;
        private int indice = 0;

        public FrmOperacion(Fachada pFachada, ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            
            InitializeComponent();
            cListaImagenes = new Imagen[100];
        }

        private void FrmOperacion_Load(object sender, EventArgs e)
        {
            timerBanner.Start();
            timerCampaña.Start();
        }

        private Campania obtenerCampania()
        {
            Campania mCampania = cFachada.GetCampaniaNow();
            int mHoraTimer = DateTime.Now.AddHours(1).Hour;
            mHoraTimer = (60 - DateTime.Now.Minute);
            return mCampania;

            //timerBanner.Interval = mHoraTimer * 60000;
            //int mHoraTimer = DateTime.Now.Hour;
            //if (mCampania != null)
            //{
            //    if (mCampania.FechaInicio.Hour <= mCampania.FechaFin.Hour)
            //    {
            //        mHoraTimer = mHoraTimer - mCampania.FechaFin.Hour;
            //    }
            //    else
            //    {
            //        mHoraTimer = mHoraTimer - 24;
            //        mHoraTimer = mHoraTimer + (mCampania.FechaFin.Hour) + 1;
            //    }
            //    timerCampaña.Interval = mHoraTimer;
            //}
            //else
            //{
            //    if(DateTime.Now.Hour == 23)
            //    {

            //    }
            //    else
            //    {
            //        mHoraTimer = DateTime.Now.Hour + 1;
            //    }
                
            //    timerCampaña.Interval = mHoraTimer;
            //}
        }

        private Banner obtenerBanner()
        {
            Banner mBanner = cFachada.GetBannerNow();
            
            int mHoraTimer = DateTime.Now.AddHours(1).Hour;
            mHoraTimer = (60 - DateTime.Now.Minute);
            timerBanner.Interval = mHoraTimer * 60000;
            return mBanner;

            //int mHoraTimer = DateTime.Now.Hour;
            //if (mBanner != null)
            //{
            //    if (mBanner.FechaInicio.Hour <= mBanner.FechaFin.Hour)
            //    {
            //        mHoraTimer = mHoraTimer - mBanner.FechaFin.Hour + 1;
            //    }
            //    else
            //    {
            //        mHoraTimer = mHoraTimer - 24;
            //        mHoraTimer = mHoraTimer + (mBanner.FechaFin.Hour) + 1;
            //    }
            //    timerBanner.Interval = mHoraTimer;
            //}
            //else
            //{
            //    mHoraTimer = DateTime.Now.AddHours(1).Hour;
            //    timerBanner.Interval = mHoraTimer;
            //}
        }

        private void lblBanner_AutoSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void timerLabelBanner_Tick(object sender, EventArgs e)
        {
            this.lblBanner.Left -= 5;
            if (lblBanner.Right <= 0)
            {
                lblBanner.Left = Width;
            }
        }

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

        private void timerCampaña_Tick(object sender, EventArgs e)
        {
            timerCampaña.Stop();
            Campania mCampania = obtenerCampania();
            if (mCampania != null)
            {
                cListaImagenes = mCampania.Imagenes.ToArray();
            }
            else
            {
                cListaImagenes = null;
            }
            timerCampaña.Start();
            timerPictureBoxCampaña.Start();
        }

        private void timerPictureBoxCampaña_Tick(object sender, EventArgs e)
        {
            if(indice >= cListaImagenes.Count())
            {
                indice = 0;
            }
            this.pictureBoxOperacion.Image = Utilidades.ByteToImage(cListaImagenes[indice].Hash);
            this.pictureBoxOperacion.SizeMode = PictureBoxSizeMode.StretchImage;
            indice = indice + 1;
            //foreach(Imagen mImagen in cListaImagenes)
            //{
            //    this.pictureBoxOperacion.Image = Utilidades.ByteToImage(mImagen.Hash);
            //    this.pictureBoxOperacion.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

        }
    }
}
