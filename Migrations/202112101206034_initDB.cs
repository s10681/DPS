namespace DPS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kontrahent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false, maxLength: 50),
                        Nip = c.String(nullable: false, maxLength: 10),
                        IdTypKontrahenta = c.Int(nullable: false),
                        OpisFirmy = c.String(maxLength: 500),
                        CzyAktywny = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypKontrahenta", t => t.IdTypKontrahenta, cascadeDelete: true)
                .Index(t => t.IdTypKontrahenta);
            
            CreateTable(
                "dbo.TypKontrahenta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Typ = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kontrahent", "IdTypKontrahenta", "dbo.TypKontrahenta");
            DropIndex("dbo.Kontrahent", new[] { "IdTypKontrahenta" });
            DropTable("dbo.TypKontrahenta");
            DropTable("dbo.Kontrahent");
        }
    }
}
