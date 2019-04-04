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
            this.ToTable("Imagen");
        }
    }
}
