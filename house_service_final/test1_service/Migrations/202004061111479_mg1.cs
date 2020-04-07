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
                        no_of_bedroom = c.Int(nullable: false),
                        kitchen = c.Int(nullable: false),
                        contact_no = c.String(),
                        price = c.Single(nullable: false),
                        isoffer = c.Boolean(nullable: false),
                        bulit_year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Houses");
        }
    }
}
