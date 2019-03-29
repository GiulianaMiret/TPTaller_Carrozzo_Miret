using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RangoFecha
    {
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public Campania Campania { get; set; } // la campaña asociada a este rango
         
        public Banner Banner { get; set; } // el banner asociado a este rango

        public ICollection<RangoHorario> RangosHorarios { get; set; } //los horarios en que se mostrara
    }
}
