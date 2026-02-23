using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEscalas.Models
{
    public class DiaCalendario
    {
        public int Dia { get; set; }
        public Color CorFundo { get; set; }
        public Color CorTexto { get; set; }
        public bool TemEscala { get; set; }
    }
}
