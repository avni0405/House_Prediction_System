namespace test1_service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imgpath : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Houses", "image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Houses", "image", c => c.Binary());
        }
    }
}
