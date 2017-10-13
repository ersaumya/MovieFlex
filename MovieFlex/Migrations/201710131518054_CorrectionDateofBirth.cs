namespace MovieFlex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectionDateofBirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime());
            DropColumn("dbo.Customers", "BirtDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BirtDate", c => c.DateTime());
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
