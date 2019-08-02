using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Data.Entity;
using Vista.EntityFramework.Services;

namespace EntityFramework.Services
{
    /// <summary>
    /// Clase repositorio del banner, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class BannerRepository : IBannerRepository
    {
        private DbSet<Banner> cDbSetBanner;

        public BannerRepository(DigitalBillboardContext pContext)
        {
            cDbSetBanner = pContext.Set<Banner>();         
        }        
        
        public Banner GetBannerNow()
        {
            Banner mBanner = cDbSetBanner.Where(x=> x.FechaInicio < DateTime.Now && x.FechaFin > DateTime.Now).FirstOrDefault();
            return mBanner;
        }

        public Dictionary<string, List<Banner>> AvailableTimes(DateTime pFechaInicio, DateTime pFechaFin)
        {
            List<Banner> mListaTodasLosBanners = cDbSetBanner.ToList();

            //Opción 1: 
            List<Banner> mListaBannersMenoresIguales = mListaTodasLosBanners.Where(x => (x.FechaFin <= pFechaFin) && (x.FechaFin >= pFechaInicio)).ToList();

            //Opción 2:
            List<Banner> mListaBannersIntermedias = mListaTodasLosBanners.Where(x => (x.FechaFin > pFechaFin) && (x.FechaInicio <= pFechaFin) && (x.FechaInicio >= pFechaInicio)).ToList();

            //Opción 3:
            List<Banner> mListaBannersMayores = mListaTodasLosBanners.Where(x => (x.FechaInicio < pFechaInicio) && (x.FechaFin > pFechaFin)).ToList();

            Dictionary<string, List<Banner>> mDiccionarioDeListas = new Dictionary<string, List<Banner>>();
            mDiccionarioDeListas.Add("MenoresIguales", mListaBannersMenoresIguales);
            mDiccionarioDeListas.Add("Intermedias", mListaBannersIntermedias);
            mDiccionarioDeListas.Add("Mayores", mListaBannersMayores);

            return mDiccionarioDeListas;
        }


        public bool AvailableHours(Banner pBanner, Dictionary<string, List<Banner>> pDictionary)
        {
            int mDias = (pBanner.FechaFin.Date - pBanner.FechaInicio.Date).Days + 1;

            int[,] mMatrizHorarios = new int[24, mDias];

            List<Banner> mListaBannersMenoresIguales = new List<Banner>();
            mListaBannersMenoresIguales = pDictionary["MenoresIguales"];
            List<Banner> mListaBannersIntermedias = new List<Banner>();
            mListaBannersIntermedias = pDictionary["Intermedias"];
            List<Banner> mListaBannersMayores = new List<Banner>();
            mListaBannersMayores = pDictionary["Mayores"];
            //Opción 1: 
            int mCantidadDias = 0;
            foreach (Banner mBanner in mListaBannersMenoresIguales)
            {
                if (mBanner.FechaInicio < pBanner.FechaInicio)
                {
                    mCantidadDias = (mBanner.FechaFin.Date - pBanner.FechaInicio.Date).Days + 1;
                    if (mCantidadDias >= mMatrizHorarios.GetLength(1))
                    {
                        mCantidadDias = mMatrizHorarios.GetLength(1) -1;
                    }
                    for (int j = 0; j <= mCantidadDias; j++)
                    {
                        if (pBanner.Id != mBanner.Id)
                        {
                            if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                            {
                                for (int i = (mBanner.FechaInicio.Hour); i < 24; i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                                for (int i = 0; i <= (mBanner.FechaFin.Hour); i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                            }
                            else
                            {
                                for (int i = (mBanner.FechaInicio.Hour); i <= (mBanner.FechaFin.Hour); i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    mCantidadDias = (mBanner.FechaFin.Date - mBanner.FechaInicio.Date).Days;
                    int mDiaInicio = (mBanner.FechaInicio.Date - pBanner.FechaInicio.Date).Days;
                    mCantidadDias = mCantidadDias + mDiaInicio;
                    if (mCantidadDias >= mMatrizHorarios.GetLength(1))
                    {
                        mCantidadDias = mMatrizHorarios.GetLength(1) - 1;
                    }
                    for (int j = mDiaInicio; j <= mCantidadDias; j++)
                    {
                        if (pBanner.Id != mBanner.Id)
                        {
                            if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                            {
                                for (int i = (mBanner.FechaInicio.Hour); i < 24; i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                                for (int i = 0; i <= (mBanner.FechaFin.Hour); i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                            }
                            else
                            {
                                for (int i = (mBanner.FechaInicio.Hour); i <= (mBanner.FechaFin.Hour); i++)
                                {
                                    if (j < mDias)
                                    {
                                        mMatrizHorarios[i, j] = 1;
                                    }
                                }
                            }
                        }

                    }
                }
            }
            //Opción 2:
            foreach (Banner mBanner in mListaBannersIntermedias)
            {
                mCantidadDias = (mBanner.FechaInicio.Date - mBanner.FechaInicio.Date).Days;

                for (int j = mCantidadDias; j < mDias; j++)
                {
                    if (pBanner.Id != mBanner.Id)
                    {
                        if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                        {
                            for (int i = (mBanner.FechaInicio.Hour); i < 24; i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                            for (int i = 0; i <= (mBanner.FechaFin.Hour); i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                        }
                        else
                        {
                            for (int i = (mBanner.FechaInicio.Hour); i <= (mBanner.FechaFin.Hour); i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                        }
                    }
                }
            }

            //Opción 3:
            foreach (Banner mBanner in mListaBannersMayores)
            {
                for (int j = 0; j <= mDias - 1; j++)
                {
                    if (pBanner.Id != mBanner.Id)
                    {
                        if (mBanner.FechaInicio.Hour > mBanner.FechaFin.Hour)
                        {
                            for (int i = (mBanner.FechaInicio.Hour); i < 24; i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                            for (int i = 0; i <= (mBanner.FechaFin.Hour); i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                        }
                        else
                        {
                            for (int i = (mBanner.FechaInicio.Hour); i <= (mBanner.FechaFin.Hour); i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j <= mDias - 1; j++)
            {
                if (pBanner.FechaInicio.Hour <= pBanner.FechaFin.Hour)
                {
                    for (int i = (pBanner.FechaInicio.Hour); i <= (pBanner.FechaFin.Hour); i++)
                    {
                        if (mMatrizHorarios[i, j] == 1)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (pBanner.FechaInicio.Hour > pBanner.FechaFin.Hour)
                    {
                        for (int i = (pBanner.FechaInicio.Hour); i < 24; i++)
                        {
                            if (mMatrizHorarios[i, j] == 1)
                            {
                                return false;
                            }
                        }
                        for (int i = 0; i <= (pBanner.FechaFin.Hour); i++)
                        {
                            if (mMatrizHorarios[i, j] == 1)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

    }
}
