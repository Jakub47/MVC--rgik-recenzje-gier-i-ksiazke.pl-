namespace rgik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmodyfikowaniePola : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gra", "Parametry_procesor", c => c.String());
            AddColumn("dbo.Gra", "Parametry_kartaGraficzna", c => c.String());
            AddColumn("dbo.Gra", "Parametry_ram", c => c.Int(nullable: false));
            AddColumn("dbo.Gra", "Parametry_pamiec", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gra", "Parametry_pamiec");
            DropColumn("dbo.Gra", "Parametry_ram");
            DropColumn("dbo.Gra", "Parametry_kartaGraficzna");
            DropColumn("dbo.Gra", "Parametry_procesor");
        }
    }
}
