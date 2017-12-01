using OS_CodeFirst.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace OS_CodeFirst
{
    
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class ControleOS : DbContext
    {
        public DbSet<StatusOS> StatusOS { get; set; }
        public DbSet<OS> OS { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Prioridade> Prioridade { get; set; }
        public DbSet<Sistema> Sistema { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<TipoServico> TipoServico { get; set; }
        public DbSet<TotalServico> TotalServico { get; set;}

        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OS_CodeFirst.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public ControleOS(): base("name=ControleOS")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}