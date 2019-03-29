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
            this.ToTable("Campania");

           
        }

    }
}
