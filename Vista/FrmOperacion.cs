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

namespace Vista
{
    public partial class FrmOperacion : Form
    {
        private readonly Fachada cFachada;
        private readonly ILogger cLogger;

        public FrmOperacion(Fachada pFachada, ILogger pLogger)
        {
            cFachada = pFachada;
            cLogger = pLogger;
            
            InitializeComponent();
        }

        private void FrmOperacion_Load(object sender, EventArgs e)
        {
            this.timerBanner_Tick(sender, e);

            iniciarCampania();
            iniciarBanner();
        }

        private void iniciarCampania()
        {
            Campania mCampania = new Campania();
            int mHoraTimer = DateTime.Now.Hour;
            if (mCampania != null)
            {
                if (mCampania.FechaInicio.Hour <= mCampania.FechaFin.Hour)
                {
                    mHoraTimer = mHoraTimer - mCampania.FechaFin.Hour;
                }
                else
                {
                    mHoraTimer = mHoraTimer - 24;
                    mHoraTimer = mHoraTimer + (mCampania.FechaFin.Hour) + 1;
                }
                timerCampaña.Interval = mHoraTimer;
            }
            else
            {
                mHoraTimer = DateTime.Now.AddHours(1).Hour;
                timerCampaña.Interval = mHoraTimer;
            }
        }

        private void iniciarBanner()
        {
            Banner mBanner = new Banner();
            
            int mHoraTimer = DateTime.Now.Hour;
            if (mBanner != null)
            {
                if (mBanner.FechaInicio.Hour <= mBanner.FechaFin.Hour)
                {
                    mHoraTimer = mHoraTimer - mBanner.FechaFin.Hour;
                }
                else
                {
                    mHoraTimer = mHoraTimer - 24;
                    mHoraTimer = mHoraTimer + (mBanner.FechaFin.Hour) + 1;
                }
                timerBanner.Interval = mHoraTimer;
            }
            else
            {
                mHoraTimer = DateTime.Now.AddHours(1).Hour;
                timerBanner.Interval = mHoraTimer;
            }
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
            string mValorLabelTextoActual = cFachada.GetTextOfActualBanner();
            if (mValorLabelTextoActual != "")
            {
                lblBanner.Text = mValorLabelTextoActual;
            }

        }
    }
}
