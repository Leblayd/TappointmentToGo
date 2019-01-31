namespace TappointmentToGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedNullableProperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MenuItems", "Spicy", c => c.Boolean());
            AlterColumn("dbo.MenuItems", "Vegetarian", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MenuItems", "Vegetarian", c => c.Boolean(nullable: false));
            AlterColumn("dbo.MenuItems", "Spicy", c => c.Boolean(nullable: false));
        }
    }
}
