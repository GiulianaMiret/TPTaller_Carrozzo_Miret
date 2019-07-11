namespace Vista.Migrations
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
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        Fuente_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fuentes", t => t.Fuente_Id, cascadeDelete: true)
                .Index(t => t.Fuente_Id);
            
            CreateTable(
                "dbo.Fuentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Valor = c.String(),
                        URL = c.String(),
                        TipoFuente = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Campanias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Imagens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hash = c.Binary(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CampaniaImagenes",
                c => new
                    {
                        CampaniaId = c.Int(nullable: false),
                        ImagenId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CampaniaId, t.ImagenId })
                .ForeignKey("dbo.Campanias", t => t.CampaniaId, cascadeDelete: true)
                .ForeignKey("dbo.Imagens", t => t.ImagenId, cascadeDelete: true)
                .Index(t => t.CampaniaId)
                .Index(t => t.ImagenId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CampaniaImagenes", "ImagenId", "dbo.Imagens");
            DropForeignKey("dbo.CampaniaImagenes", "CampaniaId", "dbo.Campanias");
            DropForeignKey("dbo.Banners", "Fuente_Id", "dbo.Fuentes");
            DropIndex("dbo.CampaniaImagenes", new[] { "ImagenId" });
            DropIndex("dbo.CampaniaImagenes", new[] { "CampaniaId" });
            DropIndex("dbo.Banners", new[] { "Fuente_Id" });
            DropTable("dbo.CampaniaImagenes");
            DropTable("dbo.Imagens");
            DropTable("dbo.Campanias");
            DropTable("dbo.Fuentes");
            DropTable("dbo.Banners");
        }
    }
}
