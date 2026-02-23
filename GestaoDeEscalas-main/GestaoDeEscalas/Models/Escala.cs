using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Maui.Scheduler;

namespace GestaoDeEscalas.Models
{
    public class Escala
    {
        public string Titulo { get; set; } = string.Empty;
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Color Cor { get; set; }
    }
}
