namespace OS_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialv4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Funcionario", "RF", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Funcionario", "Nome", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Funcionario", "Setor", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Sistema", "Nome", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Sistema", "Numero_OS", c => c.String(nullable: false, maxLength: 3, storeType: "nvarchar"));
            AlterColumn("dbo.StatusOS", "Descricao", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Status", "Nome", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.TipoServico", "Nome", c => c.String(nullable: false, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoServico", "Nome", c => c.String(unicode: false));
            AlterColumn("dbo.Status", "Nome", c => c.String(unicode: false));
            AlterColumn("dbo.StatusOS", "Descricao", c => c.String(unicode: false));
            AlterColumn("dbo.Sistema", "Numero_OS", c => c.String(unicode: false));
            AlterColumn("dbo.Sistema", "Nome", c => c.String(unicode: false));
            AlterColumn("dbo.Funcionario", "Setor", c => c.String(unicode: false));
            AlterColumn("dbo.Funcionario", "Nome", c => c.String(unicode: false));
            AlterColumn("dbo.Funcionario", "RF", c => c.String(unicode: false));
        }
    }
}
