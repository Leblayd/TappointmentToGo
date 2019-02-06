namespace TappointmentToGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedMenuItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItems", "Description", c => c.String());
            AddColumn("dbo.MenuItems", "Name", c => c.String(nullable: false));
            AddColumn("dbo.MenuItems", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.MenuItems", "Spicy", c => c.Boolean());
            AddColumn("dbo.MenuItems", "Vegetarian", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItems", "Vegetarian");
            DropColumn("dbo.MenuItems", "Spicy");
            DropColumn("dbo.MenuItems", "Price");
            DropColumn("dbo.MenuItems", "Name");
            DropColumn("dbo.MenuItems", "Description");
        }
    }
}
