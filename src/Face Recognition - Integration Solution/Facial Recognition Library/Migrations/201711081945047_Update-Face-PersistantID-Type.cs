namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFacePersistantIDType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MyFaces", "FaceListPersistantID", c => c.Guid());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MyFaces", "FaceListPersistantID", c => c.String());
        }
    }
}
