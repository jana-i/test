namespace new_proekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        BlogTitle = c.String(),
                        BLogContent = c.String(),
                        BLogTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BlogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Blogs");
        }
    }
}
