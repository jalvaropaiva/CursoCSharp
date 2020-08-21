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
using System.Xml.Serialization;

namespace ExWpf
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime x = DateTime.Parse(txtData.Text);
            MessageBox.Show(x.ToLongDateString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Triangulo t = new Triangulo(
                double.Parse(txtBase.Text),
                double.Parse(txtAltura.Text));
            MessageBox.Show(t.CalcArea().ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Medicao[] v = new Medicao[10];
            v[0] = new Medicao(36, DateTime.Now);
            v[1] = new Medicao(36.1, DateTime.Now);
            v[2] = new Medicao(36.1, DateTime.Now);
            v[3] = new Medicao(36.2, DateTime.Now);
            v[4] = new Medicao(36.1, DateTime.Now);
            v[5] = new Medicao(36.3, DateTime.Now);
            v[6] = new Medicao(37, DateTime.Now);
            v[7] = new Medicao(37.5, DateTime.Now);
            v[8] = new Medicao(37.3, DateTime.Now);
            v[9] = new Medicao(36.9, DateTime.Now);

             HttpClient 

            list.ItemsSource = v;
            //XmlSerializer xml = new XmlSerializer()
        }
    }
}
