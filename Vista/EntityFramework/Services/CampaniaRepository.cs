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

        public List<Imagen> GetImagenes (Campania pCampania)
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

        public bool AvailableHours (Campania pCampania, Dictionary<string, List<Campania>> pDictionary)
        {
            List<Campania> mListaCampaniasMenoresIguales = new List<Campania>();
            mListaCampaniasMenoresIguales = pDictionary["MenoresIguales"];
            List<Campania> mListaCampaniasIntermedias = new List<Campania>();
            mListaCampaniasIntermedias = pDictionary["Intermedias"];
            List<Campania> mListaCampaniasMayores = new List<Campania>();
            mListaCampaniasMayores = pDictionary["Mayores"];

            List<Campania> mListaAuxiliar = new List<Campania>();
            if (mListaCampaniasMenoresIguales.Count() > 0)
            {
                //Opción 1
                mListaAuxiliar = mListaCampaniasMenoresIguales.Where(x =>
                                                        (x.FechaFin.Hour <= pCampania.FechaFin.Hour) &&
                                                        (x.FechaFin.Hour >= pCampania.FechaInicio.Hour) &&
                                                        (x.Id != pCampania.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }
                //Opción 2
                mListaAuxiliar = mListaCampaniasMenoresIguales.Where(x =>
                                                        (x.FechaFin.Hour > pCampania.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour <= pCampania.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour >= pCampania.FechaInicio.Hour) &&
                                                        (x.Id != pCampania.Id)).ToList();

                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }

                //Opción 3
                mListaAuxiliar = mListaCampaniasMenoresIguales.Where(x =>
                                                    (x.FechaInicio.Hour < pCampania.FechaInicio.Hour) &&
                                                    (x.FechaFin.Hour > pCampania.FechaFin.Hour) &&
                                                    (x.Id != pCampania.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    if(!(pCampania.FechaInicio.Hour > pCampania.FechaFin.Hour))
                    {
                        return false;
                    }
                    
                }
            }
            if (mListaCampaniasIntermedias.Count() > 0)
            {
                //Opción 1
                mListaAuxiliar = mListaCampaniasIntermedias.Where(x =>
                                                        (x.FechaFin.Hour <= pCampania.FechaFin.Hour) &&
                                                        (x.FechaFin.Hour >= pCampania.FechaInicio.Hour) &&
                                                        (x.Id != pCampania.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }
                //Opción 2
                mListaAuxiliar = mListaCampaniasIntermedias.Where(x =>
                                                        (x.FechaFin.Hour > pCampania.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour <= pCampania.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour >= pCampania.FechaInicio.Hour) &&
                                                        (x.Id != pCampania.Id)).ToList();

                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }

                //Opción 3
                mListaAuxiliar = mListaCampaniasIntermedias.Where(x =>
                                                    (x.FechaInicio.Hour < pCampania.FechaInicio.Hour) &&
                                                    (x.FechaFin.Hour > pCampania.FechaFin.Hour) &&
                                                    (x.Id != pCampania.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }
            }
            if (mListaCampaniasMayores.Count() > 0)
            {
                //Opción 1
                mListaAuxiliar = mListaCampaniasMayores.Where(x =>
                                                        (x.FechaFin.Hour <= pCampania.FechaFin.Hour) &&
                                                        (x.FechaFin.Hour >= pCampania.FechaInicio.Hour) &&
                                                        (x.Id != pCampania.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }
                //Opción 2
                mListaAuxiliar = mListaCampaniasMayores.Where(x =>
                                                        (x.FechaFin.Hour > pCampania.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour <= pCampania.FechaFin.Hour) &&
                                                        (x.FechaInicio.Hour >= pCampania.FechaInicio.Hour) &&
                                                        (x.Id != pCampania.Id)).ToList();

                if (mListaAuxiliar.Count() > 0)
                {
                    return false;
                }

                //Opción 3
                mListaAuxiliar = mListaCampaniasMayores.Where(x =>
                                                    (x.FechaInicio.Hour < pCampania.FechaInicio.Hour) &&
                                                    (x.FechaFin.Hour > pCampania.FechaFin.Hour) &&
                                                    (x.Id != pCampania.Id)).ToList();
                if (mListaAuxiliar.Count() > 0)
                {
                    if (!(pCampania.FechaInicio.Hour > pCampania.FechaFin.Hour))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
