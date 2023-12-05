using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4_Matteo_Sirotti
{
    internal class Documento
    {
        public  string Codice { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public bool StatoDisponibile { get; set; }
        public int NumeroScaffale{ get; set; }
        public List<Autore> Autori { get; set; }
    }
}
