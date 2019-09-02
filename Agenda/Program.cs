using Agenda.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaContext context = new AgendaContext();
            Contato contato = new Contato();
            contato.Nome = "Teste";
            contato.Sobrenome = "Testenildo";
            contato.Nasc = new DateTime(2017, 07, 07);
            contato.Telefone = "6666-6666";
            context.Contatos.Add(contato);
            context.SaveChanges();
        }
    }
}
