namespace OS_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Setor = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dep_Func",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Funcionario_Id = c.Int(nullable: false),
                        Departamento_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.Departamento_Id, cascadeDelete: true)
                .ForeignKey("dbo.Funcionario", t => t.Funcionario_Id, cascadeDelete: true)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.Departamento_Id);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RF = c.String(nullable: false, unicode: false),
                        Nome = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OSN = c.String(nullable: false, unicode: false),
                        PA = c.String(nullable: false, unicode: false),
                        TC = c.String(nullable: false, unicode: false),
                        DataEmissao = c.DateTime(nullable: false, precision: 0),
                        ItemContratual = c.String(unicode: false),
                        DataPrevista = c.DateTime(nullable: false, precision: 0),
                        DataEntregue = c.DateTime(nullable: false, precision: 0),
                        Solicitacao = c.String(nullable: false, unicode: false),
                        Servico = c.String(unicode: false),
                        Funcionario_Id = c.Int(nullable: false),
                        Prioridade_Id = c.Int(nullable: false),
                        Sistema_Id = c.Int(nullable: false),
                        TipoServico_Id = c.Int(nullable: false),
                        Departamento_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.Departamento_Id, cascadeDelete: true)
                .ForeignKey("dbo.Funcionario", t => t.Funcionario_Id, cascadeDelete: true)
                .ForeignKey("dbo.Prioridade", t => t.Prioridade_Id, cascadeDelete: true)
                .ForeignKey("dbo.Sistema", t => t.Sistema_Id, cascadeDelete: true)
                .ForeignKey("dbo.TipoServico", t => t.TipoServico_Id, cascadeDelete: true)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.Prioridade_Id)
                .Index(t => t.Sistema_Id)
                .Index(t => t.TipoServico_Id)
                .Index(t => t.Departamento_Id);
            
            CreateTable(
                "dbo.Prioridade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nivel = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sistema",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, unicode: false),
                        Numero_OS = c.String(nullable: false, maxLength: 3, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StatusOS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, unicode: false),
                        dataAlteracao = c.DateTime(nullable: false, precision: 0),
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
                        Nome = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoServico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            DropForeignKey("dbo.OS", "TipoServico_Id", "dbo.TipoServico");
            DropForeignKey("dbo.StatusOS", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.StatusOS", "OS_Id", "dbo.OS");
            DropForeignKey("dbo.OS", "Sistema_Id", "dbo.Sistema");
            DropForeignKey("dbo.OS", "Prioridade_Id", "dbo.Prioridade");
            DropForeignKey("dbo.OS", "Funcionario_Id", "dbo.Funcionario");
            DropForeignKey("dbo.OS", "Departamento_Id", "dbo.Departamento");
            DropForeignKey("dbo.Dep_Func", "Funcionario_Id", "dbo.Funcionario");
            DropForeignKey("dbo.Dep_Func", "Departamento_Id", "dbo.Departamento");
            DropIndex("dbo.TotalServico", new[] { "OS_id" });
            DropIndex("dbo.StatusOS", new[] { "Status_Id" });
            DropIndex("dbo.StatusOS", new[] { "OS_Id" });
            DropIndex("dbo.OS", new[] { "Departamento_Id" });
            DropIndex("dbo.OS", new[] { "TipoServico_Id" });
            DropIndex("dbo.OS", new[] { "Sistema_Id" });
            DropIndex("dbo.OS", new[] { "Prioridade_Id" });
            DropIndex("dbo.OS", new[] { "Funcionario_Id" });
            DropIndex("dbo.Dep_Func", new[] { "Departamento_Id" });
            DropIndex("dbo.Dep_Func", new[] { "Funcionario_Id" });
            DropTable("dbo.TotalServico");
            DropTable("dbo.TipoServico");
            DropTable("dbo.Status");
            DropTable("dbo.StatusOS");
            DropTable("dbo.Sistema");
            DropTable("dbo.Prioridade");
            DropTable("dbo.OS");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Dep_Func");
            DropTable("dbo.Departamento");
        }
    }
}
