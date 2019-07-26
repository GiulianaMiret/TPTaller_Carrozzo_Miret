using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Windows.Forms;
using System.Drawing;

namespace EntityFramework.Services
{
    /// <summary>
    /// Clase repositorio de la Campaña, donde se va a usar el context para realizar las operaciones
    /// </summary>
    public class CampaniaRepository : ICampaniaRepository
    {
        private DbSet<Campania> cDbSetCampania;

        public CampaniaRepository(DigitalBillboardContext pContext)
        {
            cDbSetCampania = pContext.Set<Campania>();
        }

        public List<Imagen> GetImagenes(Campania pCampania)
        {
            Campania mCampania = cDbSetCampania.Find(pCampania.Id);
            if (mCampania == null)
            {
                throw new Exception("No se ha encontrado la Campaña");
            }
            if (mCampania.Imagenes.Count() < 0)
            {
                throw new Exception("La campaña no contiene imágenes");
            }
            return mCampania.Imagenes.ToList();
        }

        public void DeleteImagenes(int pIdImagen, int pIdCampania)
        {
            throw new NotImplementedException();
        }

        public void AddImagenes(int pIdImagen, int pIdCampania)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, List<Campania>> AvailableTimes(DateTime pFechaInicio, DateTime pFechaFin)
        {
            List<Campania> mListaTodasLasCampanias = cDbSetCampania.ToList();

            //Opción 1: 
            List<Campania> mListaCampaniasMenoresIguales = mListaTodasLasCampanias.Where(x =>
                                                                (x.FechaFin <= pFechaFin) &&
                                                                (x.FechaFin >= pFechaInicio)).ToList();

            //Opción 2:
            List<Campania> mListaCampaniasIntermedias = mListaTodasLasCampanias.Where(x =>
                                                            (x.FechaFin > pFechaFin) &&
                                                            (x.FechaInicio <= pFechaFin) &&
                                                            (x.FechaInicio >= pFechaInicio)).ToList();

            //Opción 3:
            List<Campania> mListaCampaniasMayores = mListaTodasLasCampanias.Where(x =>
                                                        (x.FechaInicio < pFechaInicio) &&
                                                        (x.FechaFin > pFechaFin)).ToList();

            Dictionary<string, List<Campania>> mDiccionarioDeListas = new Dictionary<string, List<Campania>>();
            mDiccionarioDeListas.Add("MenoresIguales", mListaCampaniasMenoresIguales);
            mDiccionarioDeListas.Add("Intermedias", mListaCampaniasIntermedias);
            mDiccionarioDeListas.Add("Mayores", mListaCampaniasMayores);


            return mDiccionarioDeListas;

        }

        public bool AvailableHours(Campania pCampania, Dictionary<string, List<Campania>> pDictionary)
        {
            int mDias = (pCampania.FechaFin.Date - pCampania.FechaInicio.Date).Days +1;

            int[,] mMatrizHorarios = new int[24, mDias];

            List<Campania> mListaCampaniasMenoresIguales = new List<Campania>();
            mListaCampaniasMenoresIguales = pDictionary["MenoresIguales"];
            List<Campania> mListaCampaniasIntermedias = new List<Campania>();
            mListaCampaniasIntermedias = pDictionary["Intermedias"];
            List<Campania> mListaCampaniasMayores = new List<Campania>();
            mListaCampaniasMayores = pDictionary["Mayores"];
            //Opción 1: 
            int mCantidadDias = 0;
            foreach (Campania mCampania in mListaCampaniasMenoresIguales)
            {
                if (mCampania.FechaInicio < pCampania.FechaInicio)
                {
                    mCantidadDias = (mCampania.FechaFin.Date - pCampania.FechaInicio.Date).Days +1;
                    for (int j = 0; j <= mCantidadDias; j++)
                    {
                        if (pCampania.Id != mCampania.Id)
                        {
                            if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                            {
                                for (int i = (mCampania.FechaInicio.Hour); i < 24; i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                                for (int i = 0; i <= (mCampania.FechaFin.Hour); i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                            }
                            else
                            {
                                for (int i = (mCampania.FechaInicio.Hour); i <= (mCampania.FechaFin.Hour); i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    mCantidadDias = (mCampania.FechaFin.Date - mCampania.FechaInicio.Date).Days;
                    int mDiaInicio = (mCampania.FechaInicio.Date - pCampania.FechaInicio.Date).Days;
                    mCantidadDias = mCantidadDias + mDiaInicio;
                    for (int j = mDiaInicio; j <= mCantidadDias; j++)
                    {
                        if (pCampania.Id != mCampania.Id)
                        {
                            if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                            {
                                for (int i = (mCampania.FechaInicio.Hour); i < 24; i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                                for (int i = 0; i <= (mCampania.FechaFin.Hour); i++)
                                {
                                    mMatrizHorarios[i, j] = 1;
                                }
                            }
                            else
                            {
                                for (int i = (mCampania.FechaInicio.Hour); i <= (mCampania.FechaFin.Hour); i++)
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
            foreach (Campania mCampania in mListaCampaniasIntermedias)
            {
                mCantidadDias = (mCampania.FechaInicio.Date - mCampania.FechaInicio.Date).Days;

                for (int j = mCantidadDias; j < mDias; j++)
                {
                    if (pCampania.Id != mCampania.Id)
                    {
                        if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                        {
                            for (int i = (mCampania.FechaInicio.Hour); i < 24; i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                            for (int i= 0; i <= (mCampania.FechaFin.Hour); i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                        }
                        else
                        {
                            for (int i = (mCampania.FechaInicio.Hour); i <= (mCampania.FechaFin.Hour); i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                        }
                    }
                }
            }

            //Opción 3:
            foreach (Campania mCampania in mListaCampaniasMayores)
            {
                for (int j = 0; j <= mDias-1; j++)
                {
                    if (pCampania.Id != mCampania.Id)
                    {
                        if (mCampania.FechaInicio.Hour > mCampania.FechaFin.Hour)
                        {
                            for (int i = (mCampania.FechaInicio.Hour); i < 24; i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                            for (int i = 0; i <= (mCampania.FechaFin.Hour); i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                        }
                        else
                        {
                            for (int i = (mCampania.FechaInicio.Hour); i <= (mCampania.FechaFin.Hour); i++)
                            {
                                mMatrizHorarios[i, j] = 1;
                            }
                        }
                    }
                }
            }

            for(int j = 0; j <= mDias-1; j++)
            {
                if(pCampania.FechaInicio.Hour <= pCampania.FechaFin.Hour)
                {
                    for(int i = (pCampania.FechaInicio.Hour); i <= (pCampania.FechaFin.Hour); i++)
                    {
                        if (mMatrizHorarios[i, j] == 1)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if(pCampania.FechaInicio.Hour > pCampania.FechaFin.Hour)
                    {
                        for (int i = (pCampania.FechaInicio.Hour); i < 24; i++)
                        {
                            if (mMatrizHorarios[i, j] == 1)
                            {
                                return false;
                            }
                        }
                        for (int i = 0; i <= (pCampania.FechaFin.Hour); i++)
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
