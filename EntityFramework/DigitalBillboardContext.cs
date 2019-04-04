using Core.Models;
using Core.ModelsMap;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class DigitalBillboardContext : DbContext
    {
        public DigitalBillboardContext() : base("name=Default")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CampaniaMap());

        }

        public DbSet<Campania> Campanias { get; set; }

        public DbSet<Banner> Banners { get; set; }

        //public DbSet<Fuente> Fuentes { get; set; }

        public DbSet<Imagen> Imagenes { get; set; }

        public DbSet<RangoFecha> RangosFechas { get; set; }

        public DbSet<RangoHorario> RangosHorarios { get; set; }
     }
}
