
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AgendaWPF.View
{
    /// <summary>
    /// Lógica interna para Contato.xaml
    /// </summary>
    public partial class Contato : Window
    {

        public ViewModel.ContatosViewModel ContatosViewModel { get; set; }
        public ViewModel.CompromissoViewModel CompromissoViewModel { get; set; }
        public Contato()
        {
            InitializeComponent();
            this.ContatosViewModel = new ViewModel.ContatosViewModel();
            this.CompromissoViewModel = new ViewModel.CompromissoViewModel();
            this.DataContext = this;
        }

        private void AdicionarContatoButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContatosViewModel.Adicionar();
        }

        private void RemoverContatoButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContatosViewModel.Remover();
        }

        private void SalvarContatoButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContatosViewModel.Salvar();
            this.Close();
        }

        private void CancelarContatoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}