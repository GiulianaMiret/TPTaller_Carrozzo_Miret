using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Core.Models;

namespace EntityFramework.ModelsMap
{
    public class RSSMap : EntityTypeConfiguration<RSS>
    {
        public RSSMap()
        {
            this.Property(p => p.URL)
                .IsRequired();

            this.Property(p => p.Descripcion)
                .IsRequired();

            this.Property(p => p.Valor)
                .IsRequired();

            this.Property(p => p.Codigo)
                .IsRequired();
        }
    }
}
