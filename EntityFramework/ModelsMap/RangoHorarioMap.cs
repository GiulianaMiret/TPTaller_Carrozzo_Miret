using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Core.Models;

namespace EntityFramework.ModelsMap
{
    public class RangoHorarioMap : EntityTypeConfiguration<RangoHorario>
    {
        public RangoHorarioMap()
        {
            this.ToTable("RangoHorario");
        }
    }
}
