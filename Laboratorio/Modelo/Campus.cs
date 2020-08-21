using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modelo
{
    public class Campus
    {
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public List<Laboratorio> Labs { get; }
        public Campus() { Labs = new List<Laboratorio>(); }
        public void InserirLab(Laboratorio lab) { Labs.Add(lab); }
        public void ExcluirLab(Laboratorio lab) { Labs.Remove(lab); }
    }
    public class CampusDAL
    {
        public static Campus Abrir()
        {
            string f = "c:\\temp\\Campus.xml";
            XmlSerializer xml = new XmlSerializer(typeof(Campus));
            StreamReader sr = new StreamReader(f);
            Campus c = (Campus)xml.Deserialize(sr);
            sr.Close();
            return c;
        }
        public static void Salvar(Campus c)
        {
            string f = "c:\\temp\\Campus.xml";
            XmlSerializer xml = new XmlSerializer(typeof(Campus));
            StreamWriter sw = new StreamWriter(f, false);
            xml.Serialize(sw, c);
            sw.Close();
        }
    }
}