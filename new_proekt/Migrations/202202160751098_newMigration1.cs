namespace new_proekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.clients", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.clients", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.clients", "Clubcard", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.clients", "Clubcard", c => c.String());
            AlterColumn("dbo.clients", "Phone", c => c.String());
            AlterColumn("dbo.clients", "Address", c => c.String());
        }
    }
}
