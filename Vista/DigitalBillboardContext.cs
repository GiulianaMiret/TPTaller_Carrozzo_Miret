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
        public DbSet<Campania> Campanias { get; set; }

        public DbSet<Imagen> Imagenes { get; set; }

        public DbSet<Banner> Banners { get; set; }

        public DbSet<Fuente> Fuentes { get; set; }


        public DigitalBillboardContext() : base("name=Default")
        {
            Database.SetInitializer<DigitalBillboardContext>(new CreateDatabaseIfNotExists<DigitalBillboardContext>());
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CampaniaMap());
            modelBuilder.Configurations.Add(new ImagenMap());
            modelBuilder.Configurations.Add(new BannerMap());
            modelBuilder.Configurations.Add(new FuenteMap());
            modelBuilder.Configurations.Add(new BannerRSSMap());
            modelBuilder.Configurations.Add(new BannerTextoFijoMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
