namespace kamGuro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OfertaYTrueque : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Oferta",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Trueque",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductoOfrecidoID = c.Int(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        OfertaAceptadaID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Oferta", t => t.OfertaAceptadaID)
                .ForeignKey("dbo.Producto", t => t.ProductoOfrecidoID)
                .Index(t => t.ProductoOfrecidoID)
                .Index(t => t.OfertaAceptadaID);
            
            AddColumn("dbo.Producto", "OfrecidoID", c => c.Int());
            AddColumn("dbo.Producto", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Producto", "Activo", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Producto", "OfrecidoID");
            CreateIndex("dbo.Producto", "UserID");
            AddForeignKey("dbo.Producto", "OfrecidoID", "dbo.Oferta", "ID");
            AddForeignKey("dbo.Producto", "UserID", "dbo.User", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trueque", "ProductoOfrecidoID", "dbo.Producto");
            DropForeignKey("dbo.Trueque", "OfertaAceptadaID", "dbo.Oferta");
            DropForeignKey("dbo.Producto", "UserID", "dbo.User");
            DropForeignKey("dbo.Producto", "OfrecidoID", "dbo.Oferta");
            DropIndex("dbo.Trueque", new[] { "OfertaAceptadaID" });
            DropIndex("dbo.Trueque", new[] { "ProductoOfrecidoID" });
            DropIndex("dbo.Producto", new[] { "UserID" });
            DropIndex("dbo.Producto", new[] { "OfrecidoID" });
            DropColumn("dbo.Producto", "Activo");
            DropColumn("dbo.Producto", "UserID");
            DropColumn("dbo.Producto", "OfrecidoID");
            DropTable("dbo.Trueque");
            DropTable("dbo.User");
            DropTable("dbo.Oferta");
        }
    }
}
