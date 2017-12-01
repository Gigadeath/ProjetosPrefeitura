namespace OS_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialv5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TotalServico",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        totalHoras = c.Int(nullable: false),
                        DataLimite = c.DateTime(nullable: false, precision: 0),
                        OS_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.OS", t => t.OS_id, cascadeDelete: true)
                .Index(t => t.OS_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TotalServico", "OS_id", "dbo.OS");
            DropIndex("dbo.TotalServico", new[] { "OS_id" });
            DropTable("dbo.TotalServico");
        }
    }
}
