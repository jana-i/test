namespace new_proekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.clothes", "ItemCode", c => c.String(nullable: false));
            AlterColumn("dbo.clothes", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.clothes", "Description", c => c.String());
            AlterColumn("dbo.clothes", "ItemCode", c => c.String());
        }
    }
}
