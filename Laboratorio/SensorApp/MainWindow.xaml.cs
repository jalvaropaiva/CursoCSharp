using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace SensorApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Sensor> ls = new List<Sensor>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AtualizarSensores()
        {
            list.ItemsSource = null;
            list.ItemsSource = ls;
        }

        private void NovoClick(object sender, RoutedEventArgs e)
        {
            ls.Add(new Sensor(int.Parse(txtLab.Text), TimeSpan.Parse(txtInt.Text)));
            AtualizarSensores();
        }

        private void LigarClick(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null) {
                ((Sensor)list.SelectedItem).Ligar();
                AtualizarSensores();
            }
        }
        
        private void DesligarClick(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null) { 
                ((Sensor)list.SelectedItem).Desligar();
                AtualizarSensores();
            }
        }
    }
}
