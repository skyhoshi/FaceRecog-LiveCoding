namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMyPersonGroupID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MyPersonGroups");
            AlterColumn("dbo.MyPersonGroups", "ID", c => c.Guid(nullable: false));
            AlterColumn("dbo.MyPersonGroups", "SystemUserID", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.MyPersonGroups", "SystemUserID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MyPersonGroups");
            AlterColumn("dbo.MyPersonGroups", "SystemUserID", c => c.Guid(nullable: false));
            AlterColumn("dbo.MyPersonGroups", "ID", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.MyPersonGroups", "ID");
        }
    }
}
