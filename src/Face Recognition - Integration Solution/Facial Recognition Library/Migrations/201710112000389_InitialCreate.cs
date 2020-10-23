namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyFaces",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        FaceID = c.Guid(nullable: false),
                        FaceAttributes = c.String(),
                        FaceRectangle = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyFaces");
        }
    }
}
