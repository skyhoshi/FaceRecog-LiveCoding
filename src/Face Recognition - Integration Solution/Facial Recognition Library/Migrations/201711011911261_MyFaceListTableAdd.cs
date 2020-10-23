namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFaceListTableAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyFaceLists",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        FaceListId = c.String(),
                        Name = c.String(),
                        UserData = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyFaceLists");
        }
    }
}
