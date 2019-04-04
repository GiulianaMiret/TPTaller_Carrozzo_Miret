using Core.Models;
using Core.ModelsMap;
using EntityFramework.ModelsMap;
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
            Database.SetInitializer<DigitalBillboardContext>(new CreateDatabaseIfNotExists<DigitalBillboardContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CampaniaMap());
            modelBuilder.Configurations.Add(new BannerMap());
            modelBuilder.Configurations.Add(new ImagenMap());
            modelBuilder.Configurations.Add(new RangoFechaMap());
            modelBuilder.Configurations.Add(new RangoHorarioMap());
            modelBuilder.Configurations.Add(new RSSMap());
            modelBuilder.Configurations.Add(new TextoFijoMap());

        }

        public DbSet<Campania> Campanias { get; set; }

        public DbSet<Banner> Banners { get; set; }

        public DbSet<Imagen> Imagenes { get; set; }

        public DbSet<RangoFecha> RangosFechas { get; set; }

        public DbSet<RangoHorario> RangosHorarios { get; set; }



        // probando
        public DbSet<Fuente> Fuentes { get; set; }

        //no irian estas????
        public DbSet<TextoFijo> textoFijos { get; set; }

        public DbSet<RSS> RSSs { get; set; }

    }
}
