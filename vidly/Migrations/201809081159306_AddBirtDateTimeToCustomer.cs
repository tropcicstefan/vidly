namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirtDateTimeToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirtDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirtDateTime");
        }
    }
}
