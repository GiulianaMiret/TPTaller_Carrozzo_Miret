﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Core.Models;

namespace EntityFramework.ModelsMap
{
    public class FuenteMap : EntityTypeConfiguration<Fuente>
    {
        public FuenteMap()
        {
            this.HasKey(x => x.Id);

            this.Property(p => p.URL)
                .IsRequired();

            this.Property(x => x.Descripcion)
                .IsRequired();

            this.Property(x => x.Estado)
                .IsRequired();

            this.HasRequired<BannerRSS>(x => x.BannerRSS);
        }

    }
}
