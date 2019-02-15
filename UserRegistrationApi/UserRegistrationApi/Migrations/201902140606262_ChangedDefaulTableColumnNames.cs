namespace UserRegistrationApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDefaulTableColumnNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "FirstName", c => c.String());
            AddColumn("dbo.User", "LastName", c => c.String());
            AddColumn("dbo.User", "DateOfBirth", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "DateOfBirth");
            DropColumn("dbo.User", "LastName");
            DropColumn("dbo.User", "FirstName");
        }
    }
}
