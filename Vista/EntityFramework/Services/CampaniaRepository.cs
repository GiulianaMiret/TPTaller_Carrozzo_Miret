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
        private readonly DigitalBillboardContext cBillBoardContext;

        public CampaniaRepository()
        {
            cBillBoardContext = new DigitalBillboardContext();
        }

        public IEnumerable<Campania> GetAll()
        {
            return new List<Campania>();
        }

        public Campania GetById(int pId)
        {
            return new Campania();
        }

        public void Insert(Campania pCampania)
        {

        }

        public void Delete(Campania pCampania)
        {

        }

        public void DeleteById(int pId)
        {

        }

        public void Update(Campania pCampania)
        {

        }

        public List<Imagen> GetImagenes (int pIdCampania)
        {
            Campania pCampania = cBillBoardContext.Campanias.Find(pIdCampania);
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
