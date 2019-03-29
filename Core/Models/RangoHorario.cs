using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RangoHorario
    {
        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public RangoFecha RangoFecha { get; set; }
    }
}
