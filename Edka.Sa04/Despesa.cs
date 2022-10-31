using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa04 {
    //class é um conjunto de objetos
    public class Despesa {

        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime Vencimento { get; set; }


        public override string ToString() => $"{Descricao.PadRight(10, ' ')}- - - - - - - - -R${Valor} - Venc. {Vencimento:dd/mm/yyyy}";
        
        //return $"{Descricao.PadRight(20, ' ')}-{Vencimento:dd/mm/yyyy}";

    }
}
