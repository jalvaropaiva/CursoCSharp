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
using Modelo;

namespace MonitorApp
{
    /// <summary>
    /// Lógica interna para LabsWindow.xaml
    /// </summary>
    public partial class LabsWindow : Window
    {
        private List<Laboratorio> labs;

        public LabsWindow()
        {
            InitializeComponent();
        }

        private void AtualizarLabs()
        {
            list.ItemsSource = null;
            list.ItemsSource = labs;
        }

        public void SetLabs(List<Laboratorio> labs)
        {
            this.labs = labs;
            AtualizarLabs();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            labs.Add(new Laboratorio { 
                Id = int.Parse(txtId.Text), 
                Descricao = txtDesc.Text
            });
            LaboratorioDAL.Salvar(labs);
            AtualizarLabs();
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem != null) {
                labs.Remove((Laboratorio)list.SelectedItem);
                LaboratorioDAL.Salvar(labs);
                AtualizarLabs();
            }
        }
    }
}
