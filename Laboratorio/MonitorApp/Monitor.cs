using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Modelo;

namespace MonitorApp
{
    class Monitor
    {
        private Laboratorio lab;
        private DispatcherTimer timer;
        private MonitorWindow mw;
        public Monitor(Laboratorio lab, TimeSpan intervalo)
        {
            this.lab = lab;
            timer = new DispatcherTimer();
            timer.Interval = intervalo;
            timer.Tick += timerTick;
            mw = new MonitorWindow();
            mw.Title = lab.Descricao;
        }
        public override string ToString()
        {
            return $"Monitor={lab.Descricao}   Ligado={timer.IsEnabled}";
        }
        private void timerTick(object sender, EventArgs e)
        {
            mw.list.ItemsSource = null;
            mw.list.ItemsSource = MedicaoDAL.Abrir(lab.Id);
        }
        public void Ligar()
        {
            timer.Start();
            mw.Show();
        }
        public void Desligar()
        {
            timer.Stop();
            mw.Hide();
        }
    }
}
