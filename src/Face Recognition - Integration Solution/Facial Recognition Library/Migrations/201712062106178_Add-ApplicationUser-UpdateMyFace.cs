namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddApplicationUserUpdateMyFace : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        SystemUserId = c.String(nullable: false, maxLength: 128),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.SystemUserId);
            
            AddColumn("dbo.MyFaces", "FKSystemApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.MyFaces", "FKSystemApplicationUser_Id");
            AddForeignKey("dbo.MyFaces", "FKSystemApplicationUser_Id", "dbo.ApplicationUsers", "SystemUserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyFaces", "FKSystemApplicationUser_Id", "dbo.ApplicationUsers");
            DropIndex("dbo.MyFaces", new[] { "FKSystemApplicationUser_Id" });
            DropColumn("dbo.MyFaces", "FKSystemApplicationUser_Id");
            DropTable("dbo.ApplicationUsers");
        }
    }
}
