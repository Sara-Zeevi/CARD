namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kind : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "kind");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "kind", c => c.String());
        }
    }
}
