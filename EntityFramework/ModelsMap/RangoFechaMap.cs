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
            //this.ToTable("RangoFecha");

            this.Property(p => p.FechaInicio)
                .IsRequired();

            this.Property(p => p.FechaFin)
                .IsRequired();

            this.HasMany<RangoHorario>(p => p.RangosHorarios)
                .WithRequired(s => s.RangoFecha);

            // PUEDE QUE NO TENGA UNO DE ESTOS...
            this.HasRequired<Campania>(p => p.Campania);

            this.HasRequired<Banner>(p => p.Banner);
        }
    }
}
