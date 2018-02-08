namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCustomerData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO customers (Name, IsSubscribedToNewsletter, MembershipTypeID, Birthdate) VALUES ('John Smith', 0, 1, 2/8/2018)");
            Sql("INSERT INTO customers (Name, IsSubscribedToNewsletter, MembershipTypeID, Birthdate) VALUES ('Mary Williams', 0, 2, 2/8/2018)");
            Sql("INSERT INTO customers (Name, IsSubscribedToNewsletter, MembershipTypeID, Birthdate) VALUES ('Mosh', 0, 2, 2/8/2018)");
        }
        
        public override void Down()
        {
        }
    }
}
