namespace Vista.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        HoraInicio = c.Time(nullable: false, precision: 7),
                        HoraFin = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FuenteRSSes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Estado = c.Boolean(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Titulo = c.String(),
                        Descripcion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Campanias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        HoraInicio = c.Time(nullable: false, precision: 7),
                        HoraFin = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Imagens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hash = c.Binary(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        Campania_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campanias", t => t.Campania_Id)
                .Index(t => t.Campania_Id);
            
            CreateTable(
                "dbo.BannerRSS",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Valor = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banners", t => t.Id)
                .ForeignKey("dbo.FuenteRSSes", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.BannerTextoFijo",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Texto = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banners", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BannerTextoFijo", "Id", "dbo.Banners");
            DropForeignKey("dbo.BannerRSS", "Id", "dbo.FuenteRSSes");
            DropForeignKey("dbo.BannerRSS", "Id", "dbo.Banners");
            DropForeignKey("dbo.Imagens", "Campania_Id", "dbo.Campanias");
            DropIndex("dbo.BannerTextoFijo", new[] { "Id" });
            DropIndex("dbo.BannerRSS", new[] { "Id" });
            DropIndex("dbo.Imagens", new[] { "Campania_Id" });
            DropTable("dbo.BannerTextoFijo");
            DropTable("dbo.BannerRSS");
            DropTable("dbo.Imagens");
            DropTable("dbo.Campanias");
            DropTable("dbo.FuenteRSSes");
            DropTable("dbo.Banners");
        }
    }
}
