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

namespace AgendaCompromissoApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        //private Agenda agenda = new Agenda();
        private Agenda agenda;

        public MainWindow()
        {
            InitializeComponent();
            agenda = new Agenda();
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            // Um novo compromisso é instanciado
            Compromisso c = new Compromisso();
            //c.Assunto = txtAssunto.Text;
            //c.Local = txtLocal.Text;
            //c.Data = dtData.SelectedDate.Value;
            // O compromisso é inserido na agenda
            agenda.Inserir(c);
            // Mostrar os compromissos da agenda no listbox
            list.ItemsSource = agenda.Listar();
        }

        private void Pesquisar_Click(object sender, RoutedEventArgs e)
        {
            // Critérios da pesquisa
            int m = int.Parse(txtMes.Text);
            int a = int.Parse(txtAno.Text);
            // Pesquisa
            list.ItemsSource = agenda.Pesquisar(m, a);
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            // Lista todos os compromissos
            list.ItemsSource = agenda.Listar();
        }

        private void Mostrar_Click(object sender, RoutedEventArgs e)
        {
            if (list.SelectedItem == null)
                MessageBox.Show("Nenhum compromisso selecionado!");
            else
            {
                Compromisso c = (Compromisso) list.SelectedItem;
                MessageBox.Show(c.ToString());
            }
        }

        private void NovoCompromisso_Click(object sender, RoutedEventArgs e)
        {
            CompromissoWindow w = new CompromissoWindow();
            if (w.ShowDialog().Value)
            {
                // O compromisso é inserido na agenda
                agenda.Inserir(w.GetCompromisso());
                // Mostrar os compromissos da agenda no listbox
                list.ItemsSource = agenda.Listar();
            }
        }
    }
}
