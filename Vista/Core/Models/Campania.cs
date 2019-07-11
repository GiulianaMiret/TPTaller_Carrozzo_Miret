using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Campania
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<Imagen> Imagenes { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }
    }
}
