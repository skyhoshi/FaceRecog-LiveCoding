namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateIdentityAndModifiedDateTimes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyFaceLists", "AddeDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.MyFaceLists", "ModifiedDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyFaceLists", "ModifiedDateTime");
            DropColumn("dbo.MyFaceLists", "AddeDateTime");
        }
    }
}
