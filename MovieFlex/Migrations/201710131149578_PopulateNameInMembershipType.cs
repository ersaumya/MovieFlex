namespace MovieFlex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameInMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Pay as you go' where Id=1 ");
            Sql("UPDATE MembershipTypes SET Name='Monthly' where Id=2 ");
            Sql("UPDATE MembershipTypes set Name='Quarterly' where Id=3 ");
            Sql("UPDATE MembershipTypes set Name='Annual' where Id=4 ");
        }
        
        public override void Down()
        {
        }
    }
}
