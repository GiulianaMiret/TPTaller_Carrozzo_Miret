using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Models;

namespace EntityFramework.Services
{
    public interface ICampaniaRepository
    {
        List<Imagen> GetImagenes(int pIdCampania);

        void DeleteImagenes(int pIdImagen, int pIdCampania);

        void AddImagenes(int pIdImagen, int pIdCampania);

        Dictionary<string, List<Campania>> AvailableTimes(DateTime pFechaInicio, DateTime pFechaFin);
    }
}
