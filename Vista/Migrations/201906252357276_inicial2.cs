namespace Vista.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial2 : DbMigration
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
                        HoraInicio = c.Time(nullable: false, precision: 7),
                        HoraFin = c.Time(nullable: false, precision: 7),
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
                        Campania_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campanias", t => t.Campania_Id)
                .Index(t => t.Campania_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Imagens", "Campania_Id", "dbo.Campanias");
            DropForeignKey("dbo.Banners", "Fuente_Id", "dbo.Fuentes");
            DropIndex("dbo.Imagens", new[] { "Campania_Id" });
            DropIndex("dbo.Banners", new[] { "Fuente_Id" });
            DropTable("dbo.Imagens");
            DropTable("dbo.Campanias");
            DropTable("dbo.Fuentes");
            DropTable("dbo.Banners");
        }
    }
}
