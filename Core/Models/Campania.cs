using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Campania
    {
        public string Nombre { get; set; }

        public bool Estado { get; set; }

        public ICollection<RangoFecha> RangosFechas { get; set; }

        public ICollection<Imagen> Imagenes { get; set; }

    }
}
