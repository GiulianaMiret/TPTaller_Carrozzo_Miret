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
        private readonly DigitalBillboardContext _context;
        
        public CampaniaRepository()
        {
            _context = new DigitalBillboardContext();
        }

        public IQueryable<Campania> Get(Expression<Func<Campania, bool>> predicate)
        {
            IQueryable<Campania> query = _context.Campanias.TakeWhile(predicate);
            if (query.Count() == 0)
            {
                throw new Exception("No hay Campañas");
            }
            return query;
        }

        public IEnumerable<Campania> GetAll()
        {
            List<Campania> listaCampanias = _context.Campanias.ToList();
            List<Campania> activos = new List<Campania>();
            foreach (Campania item in listaCampanias)
            {
                if (item.Estado)
                {
                    activos.Add(item);
                }
            }
            if (activos.Count() == 0)
            {
                throw new Exception("No hay Campañas");
            }
            return activos;
        }

        public Campania GetById(int pId)
        {
            Campania campania = _context.Campanias.Find(pId);
            if ((campania == null) || !(campania.Estado))
            {
                throw new Exception("No se ha encontrado la Campaña");
            }
            return campania;
        }

        public void Insert(Campania pCampania)
        {
            Campania campania = _context.Campanias.Find(pCampania.Id);
            if (campania != null)
            {
                if (!(campania.Estado))
                {
                    campania.Estado = true;
                    _context.Campanias.Attach(campania);
                }
                else
                {
                    throw new Exception("La Campaña ya existe");
                }
            }
            else
            {
                _context.Campanias.Add(pCampania);
            }
        }

        public void Delete(Campania pCampania)
        {
            Campania encontrado = _context.Campanias.Find(pCampania.Id);
            if ((encontrado == null) || !(pCampania.Estado))
            {
                throw new Exception("La Campaña no se ha encontrado");
            }
            pCampania.Estado = false;
            _context.Campanias.Attach(pCampania);

        }

        public void DeleteById(int pId)
        {
            Campania pCampania = _context.Campanias.Find(pId);
            if ((pCampania == null) || !(pCampania.Estado))
            {
                throw new Exception("La Campaña no se ha encontrado");
            }
            pCampania.Estado = false;
            _context.Campanias.Attach(pCampania);
        }

        public void Update(Campania pCampania)
        {
            Campania campaniaAnterior = _context.Campanias.Find(pCampania.Id);
            if (campaniaAnterior == null)
            {
                throw new Exception("No se ha encontrado la campaña que se quiere modificar");
            }
            _context.Campanias.Attach(pCampania);
        }

        public void Save()
        {
            _context.SaveChanges();
        }



        public List<Imagen> GetImagenes (int pIdCampania)
        {
            Campania pCampania = _context.Campanias.Find(pIdCampania);
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
            Campania pCampania = _context.Campanias.Find(pIdCampania);
            if (pCampania == null)
            {
                throw new Exception("No se ha encontrado la Campaña");
            }
            if (pCampania.Imagenes.Count() == 0)
            {
                throw new Exception("La campaña no contiene imágenes");
            }
            Imagen pImagen = pCampania.Imagenes.Where(x => x.Id == pIdImagen).First();
            if (pImagen == null)
            {
                throw new Exception("La imágen no se ha encontrado");
            }
        //    pImagen.Estado = false;
            _context.Imagenes.Attach(pImagen);
            _context.Campanias.Attach(pCampania); //no sé si es necesario esto.. porque ya está dada de baja la imagen
        }

        public void AddImagenes(int pIdImagen, int pIdCampania)
        {
            Campania pCampania = _context.Campanias.Find(pIdCampania);
            if (pCampania == null)
            {
                throw new Exception("No se ha encontrado la Campaña");
            }
            Imagen pImagen = pCampania.Imagenes.Where(x => x.Id == pIdImagen).First();
            if (pImagen != null)
            {
                throw new Exception("La imágen ya existe");
            }
            pCampania.Imagenes.Add(pImagen);
            _context.Campanias.Attach(pCampania);
        }
    }
}
