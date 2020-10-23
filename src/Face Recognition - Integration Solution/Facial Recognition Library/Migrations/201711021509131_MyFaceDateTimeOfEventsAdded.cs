namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFaceDateTimeOfEventsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyFaces", "FaceListPersistantID", c => c.String());
            AddColumn("dbo.MyFaces", "FacePersonID", c => c.String());
            AddColumn("dbo.MyFaces", "DateAddedToFaceList", c => c.DateTime());
            AddColumn("dbo.MyFaces", "DateAddedToPerson", c => c.DateTime());
            AddColumn("dbo.MyFaces", "DateAddedToPersonGroup", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyFaces", "DateAddedToPersonGroup");
            DropColumn("dbo.MyFaces", "DateAddedToPerson");
            DropColumn("dbo.MyFaces", "DateAddedToFaceList");
            DropColumn("dbo.MyFaces", "FacePersonID");
            DropColumn("dbo.MyFaces", "FaceListPersistantID");
        }
    }
}
