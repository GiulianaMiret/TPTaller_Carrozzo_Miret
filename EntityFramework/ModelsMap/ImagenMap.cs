using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Core.Models;

namespace EntityFramework.ModelsMap
{
    public class ImagenMap : EntityTypeConfiguration<Imagen>
    {
        public ImagenMap()
        {
            //this.ToTable("Imagen");

            this.Property(p => p.Nombre)
                .HasMaxLength(50)
                .IsRequired();

            this.Property(p => p.Estado)
                .IsRequired();

            this.Property(p => p.Hash)
                .IsRequired();

            this.HasRequired<Campania>(p => p.Campania);
        }
    }
}
