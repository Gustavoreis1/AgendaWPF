using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class AgendaContext : DbContext
    {
        public AgendaContext() : base("name=AgendaContext")
        {

        }
        //DESABILITAR CASCATAS

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        public System.Data.Entity.DbSet<Agenda.Classes.Contato> Contatos { get; set; }

        public System.Data.Entity.DbSet<Agenda.Classes.Compromisso> Compromissos { get; set; }
    }
}
