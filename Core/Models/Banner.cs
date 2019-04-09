using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public abstract class Banner
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public bool Estado { get; set; }
        
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }
    }
}
