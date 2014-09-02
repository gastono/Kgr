namespace kamGuro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class offer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Oferta",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ItemOfrecidoID = c.Int(nullable: false),
                        ItemAgenoID = c.Int(nullable: false),
                        Estado = c.String(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Item", t => t.ItemAgenoID)
                .ForeignKey("dbo.Item", t => t.ItemOfrecidoID)
                .Index(t => t.ItemOfrecidoID)
                .Index(t => t.ItemAgenoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Oferta", "ItemOfrecidoID", "dbo.Item");
            DropForeignKey("dbo.Oferta", "ItemAgenoID", "dbo.Item");
            DropIndex("dbo.Oferta", new[] { "ItemAgenoID" });
            DropIndex("dbo.Oferta", new[] { "ItemOfrecidoID" });
            DropTable("dbo.Oferta");
        }
    }
}
