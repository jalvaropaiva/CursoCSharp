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

namespace AgendaCompromissoApp
{
    /// <summary>
    /// Lógica interna para CompromissoWindow.xaml
    /// </summary>
    public partial class CompromissoWindow : Window
    {
        public CompromissoWindow()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        public Compromisso GetCompromisso()
        {
            Compromisso c = new Compromisso();
            c.Assunto = txtAssunto.Text;
            c.Local = txtLocal.Text;
            c.Data = dtData.SelectedDate.Value;
            return c;
        }
    }
}
