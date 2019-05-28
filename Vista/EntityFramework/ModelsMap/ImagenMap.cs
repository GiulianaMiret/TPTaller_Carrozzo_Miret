using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.ModelsMap
{
    public class ImagenMap : EntityTypeConfiguration<Imagen>
    {
        public ImagenMap()
        {
            this.HasKey(x => x.Id);

            this.Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Nombre)
                .HasMaxLength(50)
                .IsRequired();
            

            this.Property(p => p.Hash)
                .IsRequired();
        }
    }
}
