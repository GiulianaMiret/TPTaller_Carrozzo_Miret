using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Core.Models;
using Vista.Core.Models;

namespace EntityFramework.ModelsMap
{
    public class FuenteMap : EntityTypeConfiguration<Fuente>
    {
        public FuenteMap()
        {
            this.HasKey(x => x.Id);

            this
                .Map<FuenteRSS>(m => m.Requires("TipoFuente").HasValue("RSS"))
                .Map<FuenteTextoFijo>(m => m.Requires("TipoFuente").HasValue("TXT"));
            this
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

    }
}
