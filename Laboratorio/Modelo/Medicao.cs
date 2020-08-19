using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modelo
{
    public class Medicao
    {
        public int LabId { get; set; }
        public DateTime Horario { get; set; }
        public double Temperatura { get; set; }
        public override string ToString() {
            return $"{LabId} - {Horario} - {Temperatura}";
        }
    }
    public class MedicaoDAL {
        public static List<Medicao> Abrir(int labId)
        {
            string arquivo = $"c:\\temp\\Med{DateTime.Now:yyyyMMdd}Lab{labId}.json";
            string[] v = File.ReadAllLines(arquivo);
            List<Medicao> r = new List<Medicao>();
            foreach (string s in v) { 
                Medicao m = JsonSerializer.Deserialize<Medicao>(s);
                r.Add(m);
            }
            return r;
        }
        public static void Salvar(Medicao m)
        {
            string arquivo = $"c:\\temp\\Med{DateTime.Now:yyyyMMdd}Lab{m.LabId}.json";
            string s = JsonSerializer.Serialize<Medicao>(m) + Environment.NewLine;
            File.AppendAllText(arquivo, s);
        }
    }

}
