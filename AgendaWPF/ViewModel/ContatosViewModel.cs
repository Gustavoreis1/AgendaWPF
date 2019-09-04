using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda;
using Agenda.Classes;

namespace AgendaWPF.ViewModel
{
    public class ContatosViewModel
    {
        public ObservableCollection<Contato> Contatos
        { get; set; }

        public Boolean PodeRemover
        {
            get
            {
                return this.ContatoSelecionado != null;
            }
        }

        public Contato ContatoSelecionado { get; set; }
        private AgendaContext Context { get; set; }
        public ObservableCollection<Compromisso> Compross;
        public ContatosViewModel()
        {
            
            Context = new AgendaContext();
            this.Contatos =
                new ObservableCollection<Contato>(
                Context.Contatos.Include("Compromissos").ToList());
            this.ContatoSelecionado = Context
                .Contatos.FirstOrDefault();
               
            
        }

        public void Remover()
        {
            if (this.ContatoSelecionado.Id != 0)
            {
                this.Context.Contatos.Remove(
                    this.ContatoSelecionado);
            }
            this.Contatos.Remove(this.ContatoSelecionado);
        }

        public void Salvar()
        {
            this.Context.SaveChanges();
        }

        public void Adicionar()
        {
            Contato c = new Contato();
            this.Contatos.Add(c);
            this.Context.Contatos.Add(c);
            this.ContatoSelecionado = c;
        }
    }
}
