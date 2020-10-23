namespace Facial_Recognition_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMyPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MyPersons", "LastAction", c => c.String());
            AddColumn("dbo.MyPersons", "LastActionDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MyPersons", "LastActionDateTime");
            DropColumn("dbo.MyPersons", "LastAction");
        }
    }
}
