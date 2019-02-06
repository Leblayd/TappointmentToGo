namespace TappointmentToGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemadeCart : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MenuItems", "Description");
            DropColumn("dbo.MenuItems", "Name");
            DropColumn("dbo.MenuItems", "Price");
            DropColumn("dbo.MenuItems", "Spicy");
            DropColumn("dbo.MenuItems", "Vegetarian");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MenuItems", "Vegetarian", c => c.Boolean());
            AddColumn("dbo.MenuItems", "Spicy", c => c.Boolean());
            AddColumn("dbo.MenuItems", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.MenuItems", "Name", c => c.String());
            AddColumn("dbo.MenuItems", "Description", c => c.String());
        }
    }
}
