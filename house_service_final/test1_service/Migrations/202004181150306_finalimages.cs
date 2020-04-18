namespace test1_service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finalimages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Houses", "image1", c => c.String());
            AddColumn("dbo.Houses", "image2", c => c.String());
            AddColumn("dbo.Houses", "image3", c => c.String());
            AddColumn("dbo.Houses", "image4", c => c.String());
            DropColumn("dbo.Houses", "image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Houses", "image", c => c.String());
            DropColumn("dbo.Houses", "image4");
            DropColumn("dbo.Houses", "image3");
            DropColumn("dbo.Houses", "image2");
            DropColumn("dbo.Houses", "image1");
        }
    }
}
