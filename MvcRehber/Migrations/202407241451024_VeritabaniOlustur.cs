namespace MvcRehber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VeritabaniOlustur : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kisiler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        EvTelefon = c.String(),
                        CepTelefon = c.String(),
                        IsTelefon = c.String(),
                        EmailAdres = c.String(),
                        Adres = c.String(),
                        SehirId = c.Int(nullable: false),
                        CurrentId = c.Int(nullable: false),
                        TBLUserInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sehirler", t => t.SehirId, cascadeDelete: true)
                .ForeignKey("dbo.TBLUserInfoes", t => t.TBLUserInfo_Id)
                .Index(t => t.SehirId)
                .Index(t => t.TBLUserInfo_Id);
            
            CreateTable(
                "dbo.Sehirler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SehirAdi = c.String(),
                        PlakaKodu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TBLUserInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kisiler", "TBLUserInfo_Id", "dbo.TBLUserInfoes");
            DropForeignKey("dbo.Kisiler", "SehirId", "dbo.Sehirler");
            DropIndex("dbo.Kisiler", new[] { "TBLUserInfo_Id" });
            DropIndex("dbo.Kisiler", new[] { "SehirId" });
            DropTable("dbo.TBLUserInfoes");
            DropTable("dbo.Sehirler");
            DropTable("dbo.Kisiler");
        }
    }
}
