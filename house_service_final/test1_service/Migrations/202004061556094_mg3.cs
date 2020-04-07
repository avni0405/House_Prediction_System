namespace test1_service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Houses", "name", c => c.String());
            AddColumn("dbo.Houses", "bathtub", c => c.Int(nullable: false));
            DropColumn("dbo.Houses", "kitchen");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Houses", "kitchen", c => c.Int(nullable: false));
            DropColumn("dbo.Houses", "bathtub");
            DropColumn("dbo.Houses", "name");
        }
    }
}
