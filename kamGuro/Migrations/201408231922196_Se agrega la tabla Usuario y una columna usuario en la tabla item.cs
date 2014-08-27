namespace kamGuro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeagregalatablaUsuarioyunacolumnausuarioenlatablaitem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Item", "User_ID", c => c.Int());
            CreateIndex("dbo.Item", "User_ID");
            AddForeignKey("dbo.Item", "User_ID", "dbo.User", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "User_ID", "dbo.User");
            DropIndex("dbo.Item", new[] { "User_ID" });
            DropColumn("dbo.Item", "User_ID");
            DropTable("dbo.User");
        }
    }
}
