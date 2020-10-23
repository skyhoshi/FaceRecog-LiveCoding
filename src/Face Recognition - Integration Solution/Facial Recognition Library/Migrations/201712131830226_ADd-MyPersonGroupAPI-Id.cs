namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADdMyPersonGroupAPIId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyPersonGroups", "IDApi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyPersonGroups", "IDApi");
        }
    }
}
