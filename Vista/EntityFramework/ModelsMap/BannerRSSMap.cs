using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Core.Models;

namespace EntityFramework.ModelsMap
{
    public class BannerRSSMap : EntityTypeConfiguration<BannerRSS>
    {
        public BannerRSSMap()
        {
            this.ToTable("BannerRSS");

            this.Property(x => x.Valor).IsRequired();

            this.Property(x => x.Codigo).IsRequired();

            this.HasRequired<Fuente>(x => x.Fuente).WithRequiredDependent();
        }
    }
}
