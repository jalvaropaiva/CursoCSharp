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

namespace Exercicio03
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Empresa emp = new Empresa();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Novo_click(object sender, RoutedEventArgs e)
        {
            // Inserir os clientes
            emp.Inserir(new Cliente("Cliente 1", "1234", 1000));
            emp.Inserir(new Cliente("Cliente 2", "5678", 2000));
            emp.Inserir(new Cliente("Cliente 3", "9012", 3000));
            emp.Inserir(new Cliente("Cliente 4", "3456", 4000));

            Listar_click(sender, e);
        }

        private void Listar_click(object sender, RoutedEventArgs e)
        {
            // Listar os clientes
            list.ItemsSource = null;
            list.ItemsSource = emp.Listar();
        }

        private void Associar_click(object sender, RoutedEventArgs e)
        {
            // Associar os clientes
            if (list.SelectedItems.Count == 2)
            {
                Cliente x = (Cliente)list.SelectedItems[0];
                Cliente y = (Cliente)list.SelectedItems[1];
                x.SetSocio(y);
                Listar_click(sender, e);
            }
            else
                MessageBox.Show("Selecione dois clientes para realizar a sociedade!");
        }
    }
}
