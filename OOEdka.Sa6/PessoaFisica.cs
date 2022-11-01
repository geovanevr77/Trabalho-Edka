using OOEdka.Sa6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa6 {
    class PessoaFisica: Cliente
    {
        public string CPF { get; set; }

        public void Mostrar() {

            base.Mostrar();
            Console.WriteLine("CPF: {0}", CPF);
        }
    }
}
