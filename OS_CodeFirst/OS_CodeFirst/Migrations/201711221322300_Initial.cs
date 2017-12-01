namespace OS_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RF = c.String(unicode: false),
                        Nome = c.String(unicode: false),
                        Setor = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OSN = c.String(unicode: false),
                        PA = c.String(unicode: false),
                        TC = c.String(unicode: false),
                        DataEmissao = c.DateTime(nullable: false, precision: 0),
                        ItemContratual = c.String(unicode: false),
                        DataPrevista = c.DateTime(nullable: false, precision: 0),
                        DataEntregue = c.DateTime(nullable: false, precision: 0),
                        Solicitacao = c.String(unicode: false),
                        Funcionario_Id = c.Int(nullable: false),
                        Prioridade_Id = c.Int(nullable: false),
                        Sistema_Id = c.Int(nullable: false),
                        TipoServico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Funcionario", t => t.Funcionario_Id, cascadeDelete: true)
                .ForeignKey("dbo.Prioridade", t => t.Prioridade_Id, cascadeDelete: true)
                .ForeignKey("dbo.Sistema", t => t.Sistema_Id, cascadeDelete: true)
                .ForeignKey("dbo.TipoServico", t => t.TipoServico_Id, cascadeDelete: true)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.Prioridade_Id)
                .Index(t => t.Sistema_Id)
                .Index(t => t.TipoServico_Id);
            
            CreateTable(
                "dbo.Prioridade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nivel = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sistema",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                        Numero_OS = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(unicode: false),
                        OS_Id = c.Int(nullable: false),
                        Status_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OS", t => t.OS_Id, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.Status_Id, cascadeDelete: true)
                .Index(t => t.OS_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoServico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OS", "TipoServico_Id", "dbo.TipoServico");
            DropForeignKey("dbo.StatusOS", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.StatusOS", "OS_Id", "dbo.OS");
            DropForeignKey("dbo.OS", "Sistema_Id", "dbo.Sistema");
            DropForeignKey("dbo.OS", "Prioridade_Id", "dbo.Prioridade");
            DropForeignKey("dbo.OS", "Funcionario_Id", "dbo.Funcionario");
            DropIndex("dbo.StatusOS", new[] { "Status_Id" });
            DropIndex("dbo.StatusOS", new[] { "OS_Id" });
            DropIndex("dbo.OS", new[] { "TipoServico_Id" });
            DropIndex("dbo.OS", new[] { "Sistema_Id" });
            DropIndex("dbo.OS", new[] { "Prioridade_Id" });
            DropIndex("dbo.OS", new[] { "Funcionario_Id" });
            DropTable("dbo.TipoServico");
            DropTable("dbo.Status");
            DropTable("dbo.StatusOS");
            DropTable("dbo.Sistema");
            DropTable("dbo.Prioridade");
            DropTable("dbo.OS");
            DropTable("dbo.Funcionario");
        }
    }
}
