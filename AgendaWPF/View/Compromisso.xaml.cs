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
    /// Lógica interna para Compromisso.xaml
    /// </summary>
    public partial class Compromisso : Window
    {
        public ViewModel.CompromissoViewModel CompromissoViewModel { get; set; }
        public Compromisso()
        {
            InitializeComponent();
            this.CompromissoViewModel = new ViewModel.CompromissoViewModel();
            this.DataContext = this;
        }


        private void AdicionarCompromissoButton_Click(object sender, RoutedEventArgs e)
        {
            this.CompromissoViewModel.Adicionar();

        }

        private void RemoverCompromissoButton_Click(object sender, RoutedEventArgs e)
        {
            this.CompromissoViewModel.Remover();
        }

        private void SalvarCompromissoButton_Click(object sender, RoutedEventArgs e)
        {
            this.CompromissoViewModel.Salvar();
            this.Close();
        }

        private void CancelarCompromissoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AdicionarContatoButton_Click(object sender, RoutedEventArgs e)
        {
            this.CompromissoViewModel.AdicionarCont();
        }

    }
}
