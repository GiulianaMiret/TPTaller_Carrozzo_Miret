using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Imagen
    {
        public string Nombre { get; set; }

        public string Hash { get; set; }

        public bool Estado { get; set; }

        public Campania Campania { get; set; }
    }
}
