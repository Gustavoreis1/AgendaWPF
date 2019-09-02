﻿using Agenda;
using Agenda.Classes;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace AgendaWPF.ViewModel
{
    public class CompromissoViewModel
    {
        public ObservableCollection<Compromisso> Compromissos
        { get; set; }

        public Boolean PodeRemover
        {
            get
            {
                return this.CompromissoSelecionado != null;
            }
        }

        public Compromisso CompromissoSelecionado { get; set; }
        private AgendaContext Context { get; set; }
        public CompromissoViewModel()
        {
            Context = new AgendaContext();
            this.Compromissos =
                new ObservableCollection<Compromisso>(
                Context.Compromissos.ToList());
            this.CompromissoSelecionado = Context
                .Compromissos.FirstOrDefault();
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
    }
}

