namespace MovieFlex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRestNameInMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name='Quarterly' where Id=3 ");
            Sql("UPDATE MembershipTypes set Name='Annual' where Id=4 ");
        }
        
        public override void Down()
        {
        }
    }
}
