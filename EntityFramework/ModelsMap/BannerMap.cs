using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Core.Models;

namespace EntityFramework.ModelsMap
{
    public class BannerMap : EntityTypeConfiguration<Banner>
    {
        public BannerMap()
        {
            //this.ToTable("Banner");

            this.Property(p => p.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("string")
                .IsRequired()
                .HasMaxLength(50);

            this.Property(p => p.Estado)
                .HasColumnName("Estado")
                .IsRequired();

            this.HasRequired<Fuente>(p => p.Fuente);

            this.HasMany<RangoFecha>(s => s.RangosFechas)
                .WithRequired(c => c.Banner)
                .Map(cs => cs.ToTable("BannerRangosFechas"));


        }
    }
}
