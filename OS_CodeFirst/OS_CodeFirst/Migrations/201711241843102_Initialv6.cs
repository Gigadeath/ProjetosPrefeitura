namespace OS_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialv6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OS", "OSN", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.OS", "PA", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.OS", "TC", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.OS", "Solicitacao", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.OS", "Servico", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Prioridade", "Nivel", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Prioridade", "Nivel", c => c.String(unicode: false));
            AlterColumn("dbo.OS", "Servico", c => c.String(unicode: false));
            AlterColumn("dbo.OS", "Solicitacao", c => c.String(unicode: false));
            AlterColumn("dbo.OS", "TC", c => c.String(unicode: false));
            AlterColumn("dbo.OS", "PA", c => c.String(unicode: false));
            AlterColumn("dbo.OS", "OSN", c => c.String(unicode: false));
        }
    }
}
