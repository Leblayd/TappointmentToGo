namespace TappointmentToGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMaxAmounttoCart : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "MaxAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carts", "MaxAmount");
        }
    }
}
