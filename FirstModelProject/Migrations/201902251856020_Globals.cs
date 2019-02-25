namespace FirstModelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Globals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Globals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EurToRon = c.Single(nullable: false),
                        EurToDol = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Globals");
        }
    }
}
