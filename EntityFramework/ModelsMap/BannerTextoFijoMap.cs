using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.ModelsMap
{
    public class BannerTextoFijoMap : EntityTypeConfiguration<BannerTextoFijo>
    {
        public BannerTextoFijoMap()
        {
            this.ToTable("BannerTextoFijo");

            this.Property(x => x.Texto).IsRequired();
        }
    }
}
