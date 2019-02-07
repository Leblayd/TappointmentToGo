namespace TappointmentToGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrderandAddressdata : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Cart_Id", "dbo.Carts");
            DropIndex("dbo.Orders", new[] { "Cart_Id" });
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Street = c.String(),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Orders", "Telephone", c => c.String(nullable: false));
            AddColumn("dbo.Orders", "Address_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "Cart_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "Address_Id");
            CreateIndex("dbo.Orders", "Cart_Id");
            AddForeignKey("dbo.Orders", "Address_Id", "dbo.Addresses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "Cart_Id", "dbo.Carts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Cart_Id", "dbo.Carts");
            DropForeignKey("dbo.Orders", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Orders", new[] { "Cart_Id" });
            DropIndex("dbo.Orders", new[] { "Address_Id" });
            AlterColumn("dbo.Orders", "Cart_Id", c => c.Int());
            DropColumn("dbo.Orders", "Address_Id");
            DropColumn("dbo.Orders", "Telephone");
            DropColumn("dbo.Orders", "Name");
            DropTable("dbo.Addresses");
            CreateIndex("dbo.Orders", "Cart_Id");
            AddForeignKey("dbo.Orders", "Cart_Id", "dbo.Carts", "Id");
        }
    }
}
