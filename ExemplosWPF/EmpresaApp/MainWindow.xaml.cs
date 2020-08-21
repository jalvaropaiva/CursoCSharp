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
using System.Collections.ObjectModel;

namespace EmpresaApp
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

        //Cliente[] c = new Cliente[6];
        ObservableCollection<Cliente> c = new ObservableCollection<Cliente>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            c = new Cliente[6];
            c[0] = new Cliente { Nome = "Cliente 1", CPF = "1111", Limite = 1000 };
            c[1] = new Cliente { Nome = "Cliente 2", CPF = "2222", Limite = 1000 };
            c[2] = new Cliente { Nome = "Cliente 3", CPF = "3333", Limite = 1000 };
            c[3] = new Cliente { Nome = "Cliente 4", CPF = "4444", Limite = 1000 };
            c[4] = new Cliente { Nome = "Cliente 5", CPF = "8888", Limite = 1000 };
            c[5] = new Cliente { Nome = "Cliente 6", CPF = "0000", Limite = 1000 };
*/
            c.Add(new Cliente { Nome = "Cliente 1", CPF = "1111", Limite = 1000 });
            c.Add(new Cliente { Nome = "Cliente 2", CPF = "2222", Limite = 1000 });
            c.Add(new Cliente { Nome = "Cliente 3", CPF = "3333", Limite = 1000 });
            c.Add(new Cliente { Nome = "Cliente 4", CPF = "4444", Limite = 1000 });
            c.Add(new Cliente { Nome = "Cliente 5", CPF = "8888", Limite = 1000 });
            c.Add(new Cliente { Nome = "Cliente 6", CPF = "0000", Limite = 1000 });

            list.ItemsSource = c;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItems.Count == 2)
            {
                //MessageBox.Show(list.SelectedItems[0].ToString());
                //MessageBox.Show(list.SelectedItems[1].ToString());
                Cliente a = list.SelectedItems[0] as Cliente;
                Cliente b = list.SelectedItems[1] as Cliente;
                a.SetSocio(b);
                list.ItemsSource = null;
                list.ItemsSource = c;
            }
        }
    }
}

/*
            <local:Cliente Nome="Cliente 1" CPF="1234" Limite="1000" />
            <local:Cliente Nome="Cliente 2" CPF="5678" Limite="2000" />
            <local:Cliente Nome="Cliente 3" CPF="9012" Limite="3000" />
            <local:Cliente Nome="Cliente 4" CPF="3456" Limite="5000" />
*/
