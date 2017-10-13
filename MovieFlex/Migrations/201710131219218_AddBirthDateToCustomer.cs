namespace MovieFlex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirtDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirtDate");
        }
    }
}
