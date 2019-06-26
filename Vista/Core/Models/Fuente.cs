using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.Core.Models
{
    public abstract class Fuente
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public virtual string Valor { get; set; }
    }
}
