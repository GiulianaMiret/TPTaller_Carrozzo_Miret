using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;

namespace Core.Models
{
    public class FuenteTextoFijo : Fuente
    {
        public override string Valor { get; set; }
        public override void Actualizar(){}
    }
}
