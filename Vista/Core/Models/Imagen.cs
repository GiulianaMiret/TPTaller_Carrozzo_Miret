﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Imagen
    {
        public int Id { get; set; }

        public byte[] Hash { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<Campania> Campanias { get; set; }
    }
}
