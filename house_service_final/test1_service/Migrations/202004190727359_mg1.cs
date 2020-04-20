namespace test1_service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        city = c.String(),
                        area = c.String(),
                        state = c.String(),
                        squareFt = c.Int(nullable: false),
                        name = c.String(),
                        no_of_bedroom = c.Int(nullable: false),
                        bathtub = c.Int(nullable: false),
                        contact_no = c.String(),
                        price = c.Single(nullable: false),
                        isoffer = c.String(),
                        bulit_year = c.Int(nullable: false),
                        username = c.String(maxLength: 128),
                        image1 = c.String(),
                        image2 = c.String(),
                        image3 = c.String(),
                        image4 = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.users", t => t.username)
                .Index(t => t.username);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        username = c.String(nullable: false, maxLength: 128),
                        password = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Houses", "username", "dbo.users");
            DropIndex("dbo.Houses", new[] { "username" });
            DropTable("dbo.users");
            DropTable("dbo.Houses");
        }
    }
}
