namespace new_proekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class text1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "BlogTitle", c => c.String(nullable: false));
            AlterColumn("dbo.Blogs", "BLogContent", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "BLogContent", c => c.String());
            AlterColumn("dbo.Blogs", "BlogTitle", c => c.String());
        }
    }
}
