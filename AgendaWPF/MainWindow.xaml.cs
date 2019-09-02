using AgendaWPF.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendaWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ContatosButton_Click(object sender, RoutedEventArgs e)
        {
            Contato C = new Contato();
            C.Show();

        }

        private void CompromissoButton_Click(object sender, RoutedEventArgs e)
        {
            Compromisso Cmp = new Compromisso();
            Cmp.Show();
        }
    }
}
