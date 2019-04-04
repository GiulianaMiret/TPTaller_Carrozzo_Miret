using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace EntityFramework.ModelsMap
{
    public class RangoFechaMap : EntityTypeConfiguration<RangoFecha>
    {
        public RangoFechaMap()
        {
            this.ToTable("RangoFecha");
        }
    }
}
