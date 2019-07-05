using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Linq.Expressions;
using System.Data.Entity;

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

        public List<Imagen> GetImagenes (int pIdCampania)
        {
            Campania pCampania = cDbSetCampania.Find(pIdCampania);
            if (pCampania == null)
            {
                throw new Exception("No se ha encontrado la Campaña");
            }
            if (pCampania.Imagenes.Count() == 0)
            {
                throw new Exception("La campaña no contiene imágenes");
            }
            return pCampania.Imagenes.ToList();
        }

        public void DeleteImagenes(int pIdImagen, int pIdCampania)
        {
            throw new NotImplementedException();
        }

        public void AddImagenes(int pIdImagen, int pIdCampania)
        {
            throw new NotImplementedException();
        }
    }
}
