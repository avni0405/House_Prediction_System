namespace test1_service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "image1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "image1");
        }
    }
}
