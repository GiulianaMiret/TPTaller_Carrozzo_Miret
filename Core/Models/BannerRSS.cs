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
        public int Codigo { get; set; }

        public string Valor { get; set; }
        //[Required]
        public virtual Fuente Fuente { get; set; }
    }
}
