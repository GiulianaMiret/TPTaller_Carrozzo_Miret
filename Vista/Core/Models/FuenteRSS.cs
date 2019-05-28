using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class FuenteRSS
    {
        public int Id { get; set; }

        public bool Estado { get; set; }

        [DataType(DataType.Url)]

        public string URL { get; set; }

        public DateTime Fecha { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }
    }
}
