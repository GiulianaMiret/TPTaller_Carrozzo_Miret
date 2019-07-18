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
            if (mCampania.Imagenes.Count() == 0)
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
            List<Campania> mListaCampaniasMenoresIguales = mListaTodasLasCampanias.Where(x => (x.FechaFin <= pFechaFin) && (x.FechaFin >= pFechaInicio)).ToList();

            //Opción 2:
            List<Campania> mListaCampaniasIntermedias = mListaTodasLasCampanias.Where(x => (x.FechaFin > pFechaFin) && (x.FechaInicio <= pFechaFin) && (x.FechaInicio >= pFechaInicio)).ToList();

            //Opción 3:
            List<Campania> mListaCampaniasMayores = mListaTodasLasCampanias.Where(x => (x.FechaInicio < pFechaInicio) && (x.FechaFin > pFechaFin)).ToList();

            Dictionary<string, List<Campania>> mDiccionarioDeListas = new Dictionary<string, List<Campania>>();
            mDiccionarioDeListas.Add("MenoresIguales", mListaCampaniasMenoresIguales);
            mDiccionarioDeListas.Add("Intermedias", mListaCampaniasIntermedias);
            mDiccionarioDeListas.Add("Mayores", mListaCampaniasMayores);


            return mDiccionarioDeListas;

        }
    }
}
