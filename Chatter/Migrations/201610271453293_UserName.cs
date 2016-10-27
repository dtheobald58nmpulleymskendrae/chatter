namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Username");
        }
    }
}
