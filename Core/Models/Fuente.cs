using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Fuente
    {
        public int Id { get; set; }

        public bool Estado { get; set; }

        public string URL { get; set; }

        public string Descripcion { get; set; }

        public virtual BannerRSS BannerRSS { get; set; }
    }
}
