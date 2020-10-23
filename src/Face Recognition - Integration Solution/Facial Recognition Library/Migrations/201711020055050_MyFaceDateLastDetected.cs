namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFaceDateLastDetected : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyFaces", "DateLastDetected", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyFaces", "DateLastDetected");
        }
    }
}
