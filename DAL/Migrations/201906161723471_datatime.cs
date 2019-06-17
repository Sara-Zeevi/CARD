namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datatime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "DateOfBirth", c => c.String(nullable: false));
        }
    }
}
