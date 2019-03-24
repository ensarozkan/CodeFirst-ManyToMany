namespace nt_codeFirsManyToMany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Egitmenler",
                c => new
                    {
                        EgitmenId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                    })
                .PrimaryKey(t => t.EgitmenId);
            
            CreateTable(
                "dbo.Ögrenciler",
                c => new
                    {
                        OgrenciId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                    })
                .PrimaryKey(t => t.OgrenciId);
            
            CreateTable(
                "dbo.OgrenciEgitmen",
                c => new
                    {
                        Ogrenci_OgrenciId = c.Int(nullable: false),
                        Egitmen_EgitmenId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_OgrenciId, t.Egitmen_EgitmenId })
                .ForeignKey("dbo.Ögrenciler", t => t.Ogrenci_OgrenciId, cascadeDelete: true)
                .ForeignKey("dbo.Egitmenler", t => t.Egitmen_EgitmenId, cascadeDelete: true)
                .Index(t => t.Ogrenci_OgrenciId)
                .Index(t => t.Egitmen_EgitmenId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciEgitmen", "Egitmen_EgitmenId", "dbo.Egitmenler");
            DropForeignKey("dbo.OgrenciEgitmen", "Ogrenci_OgrenciId", "dbo.Ögrenciler");
            DropIndex("dbo.OgrenciEgitmen", new[] { "Egitmen_EgitmenId" });
            DropIndex("dbo.OgrenciEgitmen", new[] { "Ogrenci_OgrenciId" });
            DropTable("dbo.OgrenciEgitmen");
            DropTable("dbo.Ögrenciler");
            DropTable("dbo.Egitmenler");
        }
    }
}
