namespace OS_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Funcionario", "status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Prioridade", "status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sistema", "status", c => c.Boolean(nullable: false));
            AddColumn("dbo.TipoServico", "status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TipoServico", "status");
            DropColumn("dbo.Sistema", "status");
            DropColumn("dbo.Prioridade", "status");
            DropColumn("dbo.Funcionario", "status");
        }
    }
}
