namespace Vista.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class borrar_campoEstado_de_imagen : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Imagens", "Estado");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imagens", "Estado", c => c.Boolean(nullable: false));
        }
    }
}
