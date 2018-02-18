namespace rgik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gatunek",
                c => new
                    {
                        GatunekId = c.Int(nullable: false, identity: true),
                        NazwaGatunku = c.String(nullable: false, maxLength: 100),
                        NazwaPlikuObrazkaGatunku = c.String(),
                    })
                .PrimaryKey(t => t.GatunekId);
            
            CreateTable(
                "dbo.Gra",
                c => new
                    {
                        GraId = c.Int(nullable: false, identity: true),
                        GatunekId = c.Int(nullable: false),
                        PlatformaId = c.Int(nullable: false),
                        NazwaGry = c.String(nullable: false, maxLength: 100),
                        Producent = c.String(nullable: false, maxLength: 100),
                        Wydawca = c.String(),
                        WydawcaPL = c.String(),
                        DataWydania = c.DateTime(nullable: false),
                        DataWydaniaWPolsce = c.DateTime(nullable: false),
                        Ocena = c.Single(nullable: false),
                        TrybGry = c.Int(nullable: false),
                        NazwaPlikuObrazka = c.String(),
                        Opis = c.String(nullable: false),
                        OpisSkrocony = c.String(nullable: false, maxLength: 100),
                        SzacowanaDlugoscGry = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GraId)
                .ForeignKey("dbo.Gatunek", t => t.GatunekId, cascadeDelete: true)
                .ForeignKey("dbo.Platforma", t => t.PlatformaId, cascadeDelete: true)
                .Index(t => t.GatunekId)
                .Index(t => t.PlatformaId);
            
            CreateTable(
                "dbo.Ksiazka",
                c => new
                    {
                        KsiazkaId = c.Int(nullable: false, identity: true),
                        GatunekId = c.Int(nullable: false),
                        NazwaKsiazki = c.String(nullable: false, maxLength: 100),
                        Producent = c.String(nullable: false, maxLength: 100),
                        Wydawca = c.String(),
                        WydawcaPL = c.String(),
                        DataWydania = c.DateTime(nullable: false),
                        DataWydaniaWPolsce = c.DateTime(nullable: false),
                        Ocena = c.Single(nullable: false),
                        NazwaPlikuObrazka = c.String(),
                        Opis = c.String(nullable: false),
                        OpisSkrocony = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.KsiazkaId)
                .ForeignKey("dbo.Gatunek", t => t.GatunekId, cascadeDelete: true)
                .Index(t => t.GatunekId);
            
            CreateTable(
                "dbo.Platforma",
                c => new
                    {
                        PlatformaId = c.Int(nullable: false, identity: true),
                        NazwaPlatformy = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.PlatformaId);
            
            CreateTable(
                "dbo.PublikacjaGry",
                c => new
                    {
                        PublikacjaGryId = c.Int(nullable: false, identity: true),
                        GraId = c.Int(nullable: false),
                        GatunekId = c.Int(nullable: false),
                        DataPublikacji = c.DateTime(nullable: false),
                        OcenaPublikacji = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PublikacjaGryId);
            
            CreateTable(
                "dbo.PublikacjaKsiazki",
                c => new
                    {
                        PublikacjaKsiazkiId = c.Int(nullable: false, identity: true),
                        KsiazkaId = c.Int(nullable: false),
                        GatunekId = c.Int(nullable: false),
                        DataPublikacji = c.DateTime(nullable: false),
                        OcenaPublikacji = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PublikacjaKsiazkiId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gra", "PlatformaId", "dbo.Platforma");
            DropForeignKey("dbo.Ksiazka", "GatunekId", "dbo.Gatunek");
            DropForeignKey("dbo.Gra", "GatunekId", "dbo.Gatunek");
            DropIndex("dbo.Ksiazka", new[] { "GatunekId" });
            DropIndex("dbo.Gra", new[] { "PlatformaId" });
            DropIndex("dbo.Gra", new[] { "GatunekId" });
            DropTable("dbo.PublikacjaKsiazki");
            DropTable("dbo.PublikacjaGry");
            DropTable("dbo.Platforma");
            DropTable("dbo.Ksiazka");
            DropTable("dbo.Gra");
            DropTable("dbo.Gatunek");
        }
    }
}
