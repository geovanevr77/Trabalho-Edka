using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa05 {
    internal class Disciplina {

        public string Materia { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }

        public override string ToString() => $"{Materia,-10}------{Inicio: dd/MM/yyyy}------{Termino: dd/MM/yyyy}";
        

    }
}
