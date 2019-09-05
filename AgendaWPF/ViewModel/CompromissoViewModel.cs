using Agenda;
using Agenda.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AgendaWPF.ViewModel
{
    public class CompromissoViewModel
    {
        public ObservableCollection<Compromisso> Compromissos
        { get; set; }

        public ObservableCollection<Contato> Contatos
        { get; set; }

        public Boolean PodeRemover
        {
            get
            {
                return this.CompromissoSelecionado != null;
            }
        }

        public Compromisso CompromissoSelecionado { get; set; }
        public Contato ContatoSelecionado { get; set; }
        private AgendaContext Context { get; set; }
        public CompromissoViewModel()
        {
            Context = new AgendaContext();
            IList<Contato> parts = new List<Contato>();
            this.Compromissos =
                new ObservableCollection<Compromisso>(
                Context.Compromissos.Include("Participantes").ToList());
            this.CompromissoSelecionado = Context
                .Compromissos.FirstOrDefault();
            this.CompromissoSelecionado.Participantes = parts;
            this.Contatos =
                new ObservableCollection<Contato>(
                    Context.Contatos.ToList());
            this.ContatoSelecionado = Context.Contatos.FirstOrDefault();
        }

        public void Remover()
        {
            if (this.CompromissoSelecionado.Id != 0)
            {
                this.Context.Compromissos.Remove(
                    this.CompromissoSelecionado);
            }
            this.Compromissos.Remove(this.CompromissoSelecionado);
        }

        public void Salvar()
        {
            this.Context.SaveChanges();
        }

        public void Adicionar()
        {
            Compromisso cmp = new Compromisso();
            this.Compromissos.Add(cmp);
            this.Context.Compromissos.Add(cmp);
            this.CompromissoSelecionado = cmp;
        }

        public void AdicionarCont()
        {

            this.CompromissoSelecionado.Participantes.Add(this.ContatoSelecionado);
        }
    }
}

