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
            this.HasKey(x => x.Id);

            this.Property(p => p.Nombre)
                            .HasColumnName("Nombre")
                            .HasColumnType("string")
                            .IsRequired()
                            .HasMaxLength(50);

            this.Property(p => p.Estado)
                            .HasColumnName("Estado")
                            .IsRequired();

            Map<BannerRSS>(x => x.Requires("Type")
                                    .HasValue("R")
                                    .HasColumnType("char")
                                    .HasMaxLength(1));

            Map<BannerTextoFijo>(x => x.Requires("Type")
                                       .HasValue("T"));

        }
    }
}
