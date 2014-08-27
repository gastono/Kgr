namespace kamGuro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removenamefromItem : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Item", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "name", c => c.String());
        }
    }
}
