namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Timestamp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Message_ID", c => c.Int());
            CreateIndex("dbo.Messages", "Message_ID");
            AddForeignKey("dbo.Messages", "Message_ID", "dbo.Messages", "ID");
            DropColumn("dbo.Messages", "Timestamp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Timestamp", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Messages", "Message_ID", "dbo.Messages");
            DropIndex("dbo.Messages", new[] { "Message_ID" });
            DropColumn("dbo.Messages", "Message_ID");
        }
    }
}
