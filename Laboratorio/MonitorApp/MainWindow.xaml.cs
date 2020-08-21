using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
using Modelo;

namespace MonitorApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Laboratorio> labs;
        private List<Monitor> mlabs = new List<Monitor>();

        public MainWindow()
        {
            InitializeComponent();
            IniciarLabs();
        }

        private void AtualizarLabs()
        {
            cbLab.ItemsSource = null;
            cbLab.ItemsSource = labs;
        }

        private void AtualizarMonitores()
        {
            list.ItemsSource = null;
            list.ItemsSource = mlabs;
        }

        private void IniciarLabs()
        {
            try {
                labs = LaboratorioDAL.Abrir();
            }
            catch {
                labs = new List<Laboratorio>();
            }
            AtualizarLabs();
        }

        private void LabsClick(object sender, RoutedEventArgs e)
        {
            LabsWindow w = new LabsWindow();
            w.SetLabs(labs);
            w.ShowDialog();
            AtualizarLabs();
        }

        private void NovoClick(object sender, RoutedEventArgs e)
        {
            Laboratorio lab = (Laboratorio)(cbLab.SelectedItem);
            mlabs.Add(new Monitor(lab, TimeSpan.Parse(txtInt.Text)));
            AtualizarMonitores();
        }

        private void LigarClick(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null) {
                ((Monitor)list.SelectedItem).Ligar();
                AtualizarMonitores();
            }
        }

        private void DesligarClick(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null) {
                ((Monitor)list.SelectedItem).Desligar();
                AtualizarMonitores();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
