namespace OS_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialv3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StatusOS", "dataAlteracao", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StatusOS", "dataAlteracao");
        }
    }
}
