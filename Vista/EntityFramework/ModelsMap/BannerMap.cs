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
    public class BannerMap : EntityTypeConfiguration<Banner>
    {
        public BannerMap()
        {
            this.HasKey(x => x.Id);

            this.Property(a => a.Id)
                            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Nombre)
                            .HasColumnName("Nombre")
                            .IsRequired()
                            .HasMaxLength(50);

            this.HasRequired(x => x.Fuente);
            
        }
    }
}
