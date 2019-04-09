namespace EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Estado = c.Boolean(nullable: false),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        HoraInicio = c.Time(nullable: false, precision: 7),
                        HoraFin = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fuentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        URL = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        BannerRSS_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BannerRSS", t => t.BannerRSS_Id)
                .Index(t => t.BannerRSS_Id);
            
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
                "dbo.Imagenes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Hash = c.Byte(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        Campania_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campanias", t => t.Campania_Id, cascadeDelete: true)
                .Index(t => t.Campania_Id);
            
            CreateTable(
                "dbo.BannerRSS",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        Valor = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banners", t => t.Id)
                .ForeignKey("dbo.Fuentes", t => t.Id)
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
            DropForeignKey("dbo.BannerRSS", "Id", "dbo.Fuentes");
            DropForeignKey("dbo.BannerRSS", "Id", "dbo.Banners");
            DropForeignKey("dbo.Imagenes", "Campania_Id", "dbo.Campanias");
            DropForeignKey("dbo.Fuentes", "BannerRSS_Id", "dbo.BannerRSS");
            DropIndex("dbo.BannerTextoFijo", new[] { "Id" });
            DropIndex("dbo.BannerRSS", new[] { "Id" });
            DropIndex("dbo.Imagenes", new[] { "Campania_Id" });
            DropIndex("dbo.Fuentes", new[] { "BannerRSS_Id" });
            DropTable("dbo.BannerTextoFijo");
            DropTable("dbo.BannerRSS");
            DropTable("dbo.Imagenes");
            DropTable("dbo.Campanias");
            DropTable("dbo.Fuentes");
            DropTable("dbo.Banners");
        }
    }
}
