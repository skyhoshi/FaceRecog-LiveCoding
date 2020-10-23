namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMyPersonMyPersonFace : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyPersons",
                c => new
                    {
                        SystemPersonId = c.Guid(nullable: false, identity: true),
                        PersonId = c.Guid(nullable: false),
                        Name = c.String(),
                        UserData = c.String(),
                    })
                .PrimaryKey(t => t.SystemPersonId);
            
            CreateTable(
                "dbo.MyPersonFaces",
                c => new
                    {
                        SystemPersonFaceId = c.Guid(nullable: false, identity: true),
                        FK_SystemPersonId = c.Guid(nullable: false),
                        PersistedFaceId = c.Guid(nullable: false),
                        MyPerson_SystemPersonId = c.Guid(),
                    })
                .PrimaryKey(t => t.SystemPersonFaceId)
                .ForeignKey("dbo.MyPersons", t => t.MyPerson_SystemPersonId)
                .Index(t => t.MyPerson_SystemPersonId);
            
            AddColumn("dbo.MyPersonGroups", "SystemUserID", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyPersonFaces", "MyPerson_SystemPersonId", "dbo.MyPersons");
            DropIndex("dbo.MyPersonFaces", new[] { "MyPerson_SystemPersonId" });
            DropColumn("dbo.MyPersonGroups", "SystemUserID");
            DropTable("dbo.MyPersonFaces");
            DropTable("dbo.MyPersons");
        }
    }
}
