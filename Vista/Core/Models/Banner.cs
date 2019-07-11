using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;

namespace Core.Models
{
    public class Banner
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public virtual Fuente Fuente { get; set; }
    }
}
