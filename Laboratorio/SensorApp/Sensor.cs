using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Modelo;

namespace SensorApp
{
    class Sensor
    {
        private int labId;
        private DispatcherTimer timer;
        private Random random = new Random();
        public Sensor(int labId, TimeSpan intervalo)
        {
            this.labId = labId;
            timer = new DispatcherTimer();
            timer.Interval = intervalo;
            timer.Tick += timerTick;
        }
        public override string ToString()
        {
            return $"Sensor={labId}   Ligado={timer.IsEnabled}";
        }
        private void timerTick(object sender, EventArgs e)
        {
            Medicao m = new Medicao
            {
                LabId = labId,
                Horario = DateTime.Now,
                Temperatura = random.Next(200, 300) / 10.0
            };
            MedicaoDAL.Salvar(m);
        }
        public void Ligar()
        {
            timer.Start();
        }
        public void Desligar()
        {
            timer.Stop();
        }
    }
}
