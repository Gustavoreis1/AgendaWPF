namespace Agenda
{
    using Agenda.Classes;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AgendaADO : DbContext
    {
        // Your context has been configured to use a 'AgendaADO' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Agenda.AgendaADO' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AgendaADO' 
        // connection string in the application configuration file.
        public AgendaADO()
            : base("name=AgendaContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contato>();
            modelBuilder.Entity<Compromisso>();
            

        }
        public virtual DbSet<Contato> Contatos { get; set; }
        public virtual DbSet<Compromisso> Compromissos { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}