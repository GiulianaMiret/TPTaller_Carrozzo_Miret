using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ModelsMap
{
    public class CampaniaMap : EntityTypeConfiguration<Campania>
    {
        public CampaniaMap()
        {
            this.HasKey(x => x.Id);

            this.Property(p => p.Nombre)
                .HasMaxLength(50)
                .IsRequired();

            this.Property(p => p.Estado)
                .IsRequired();

            this.HasMany<Imagen>(i => i.Imagenes)
                .WithRequired(k => k.Campania)
                .Map(ki => ki.ToTable("CampaniaImagenes"));
           
        }

    }
}
