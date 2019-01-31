namespace TappointmentToGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPriceToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MenuItems", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MenuItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
