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

        public IEnumerable<Campania> GetAll()
        {
            List<Campania> listaCampanias = _context.Campanias.ToList();
            List<Campania> activos = new List<Campania>();
            foreach (Campania item in listaCampanias)
            {
                
                    activos.Add(item);
                
            }
            return activos;
        }

        public Campania GetById(int pId)
        {
            Campania campania = _context.Campanias.Find(pId);
            return campania;
        }

        public void Insert(Campania pCampania)
        {
            Campania campania = _context.Campanias.Find(pCampania.Id);
            if (campania != null)
            {
                    _context.Campanias.Attach(campania);
            }
            else
            {
                _context.Campanias.Add(pCampania);
            }
        }

        public void Delete(Campania pCampania)
        {
            Campania encontrado = _context.Campanias.Find(pCampania.Id);
            _context.Campanias.Attach(pCampania);
        }

        public void DeleteById(int pId)
        {
            Campania pCampania = _context.Campanias.Find(pId);
            _context.Campanias.Attach(pCampania);
        }

        public void Update(Campania pCampania)
        {
            Campania campaniaAnterior = _context.Campanias.Find(pCampania.Id);
            _context.Campanias.Attach(pCampania);
        }

        public void Save()
        {
            _context.SaveChanges();
        }



        public List<Imagen> GetImagenes (int pIdCampania)
        {
            Campania pCampania = _context.Campanias.Find(pIdCampania);
            return pCampania.Imagenes.ToList();
        }

        public void DeleteImagenes(int pIdImagen, int pIdCampania)
        {
            Campania pCampania = _context.Campanias.Find(pIdCampania);
            Imagen pImagen = pCampania.Imagenes.Where(x => x.Id == pIdImagen).First();
            _context.Imagenes.Attach(pImagen);
            _context.Campanias.Attach(pCampania); //no sé si es necesario esto.. porque ya está dada de baja la imagen
        }

        public void AddImagenes(int pIdImagen, int pIdCampania)
        {
            Campania pCampania = _context.Campanias.Find(pIdCampania);
            Imagen pImagen = pCampania.Imagenes.Where(x => x.Id == pIdImagen).First();
            pCampania.Imagenes.Add(pImagen);
            _context.Campanias.Attach(pCampania);
        }
    }
}
