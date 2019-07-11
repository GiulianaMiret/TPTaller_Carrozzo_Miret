using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

            this.Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Nombre)
                .HasMaxLength(50)
                .IsRequired();

            this.HasMany(i => i.Imagenes)
                .WithMany(c => c.Campanias)
                .Map(ci =>
                {
                    ci.MapLeftKey("CampaniaId");
                    ci.MapRightKey("ImagenId");
                    ci.ToTable("CampaniaImagenes");
                });
        }

    }
}
