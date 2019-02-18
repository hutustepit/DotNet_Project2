namespace FirstModelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnPriceRON1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "PriceRon", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "PriceRon");
        }
    }
}
