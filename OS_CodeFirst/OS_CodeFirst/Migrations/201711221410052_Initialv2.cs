namespace OS_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OS", "Servico", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OS", "Servico");
        }
    }
}
