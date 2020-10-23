namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMyPersonGroups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyPersonGroups",
                c => new
                    {
                        ID = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        UserData = c.String(),
                        Status = c.String(),
                        createDateTime = c.DateTime(nullable: false),
                        LastAction = c.String(),
                        LastActionDateTime = c.DateTime(),
                        StatusMessage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyPersonGroups");
        }
    }
}
