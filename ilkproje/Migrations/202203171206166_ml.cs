namespace ilkproje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ml : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.yazars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        yazarAdi = c.String(),
                        yazarSoyad = c.String(),
                        Biyografi = c.String(),
                        dogumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.yazars");
        }
    }
}
