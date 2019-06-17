namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TZ : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "TZ", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "TZ");
        }
    }
}
