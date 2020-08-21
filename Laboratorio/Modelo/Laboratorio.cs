using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelo
{
    public class Laboratorio
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public override string ToString() {
            return $"{Id} - {Descricao}";
        }
    }

    public class LaboratorioDAL
    {
        public static List<Laboratorio> Abrir()
        {
            string arquivo = "c:\\temp\\Laboratorio.xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Laboratorio>));
            StreamReader f = new StreamReader(arquivo);
            List<Laboratorio> labs = (List<Laboratorio>)xml.Deserialize(f);
            f.Close();
            return labs;
        }
        public static void Salvar(List<Laboratorio> labs)
        {
            string arquivo = "c:\\temp\\Laboratorio.xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Laboratorio>));
            StreamWriter f = new StreamWriter(arquivo, false);
            xml.Serialize(f, labs);
            f.Close();
        }

    }
}
