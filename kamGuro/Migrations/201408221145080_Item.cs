namespace kamGuro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Item : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "name");
        }
    }
}
