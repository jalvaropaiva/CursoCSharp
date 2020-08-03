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

namespace TrianguloApp
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
            // Triangulo x = new Triangulo();
            double b = double.Parse(txtBase.Text);
            double h = double.Parse(txtAltura.Text);
            Triangulo x = new Triangulo { Base = b, Altura = h };
            //x.SetBase(b);
            //x.SetAltura(h);
            x.Base = b;
            x.Altura = h;
            //txtArea.Text = x.CalcArea().ToString();
            txtArea.Text = x.Area.ToString();
        }
    }
}
