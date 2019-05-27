using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class BannerRSS : Banner
    {
        public string Valor { get; set; }

        public virtual FuenteRSS Fuente { get; set; }
    }
}
