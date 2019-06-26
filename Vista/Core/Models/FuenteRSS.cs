﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Core.Models;

namespace Core.Models
{
    public class FuenteRSS : Fuente
    {

        [DataType(DataType.Url)]

        public string URL { get; set; }

        public override string Valor { get; set; }
    }
}
