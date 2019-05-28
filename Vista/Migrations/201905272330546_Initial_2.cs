namespace Vista.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FuenteRSSes", "URL", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FuenteRSSes", "URL");
        }
    }
}
