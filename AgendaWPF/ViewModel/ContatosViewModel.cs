using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaWPF;

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
        private AgendaContext context { get; set; }
        public ContatosViewModel()
        {
            context = new AgendaContext();
            this.Contatos =
                new ObservableCollection<Contato>(
                context.Contatos.ToList());
            this.ContatoSelecionado = context
                .Contatos.FirstOrDefault();
        }

        public void Remover()
        {
            if (this.ContatoSelecionado.Id != 0)
            {
                this.context.Contatos.Remove(
                    this.ContatoSelecionado);
            }
            this.Contatos.Remove(this.ContatoSelecionado);
        }

        public void Salvar()
        {
            this.context.SaveChanges();
        }

        public void Adicionar()
        {
            Contatos c = new Contatos();
            this.Contatos.Add(c);
            this.context.Contatos.Add(c);
            this.ContatoSelecionado = c;
        }
    }
}
