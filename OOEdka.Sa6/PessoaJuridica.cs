using OOEdka.Sa6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa6 {
    class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }

        public void Mostrar() {

            base.Mostrar();
            Console.WriteLine("CNPJ: {0}", CNPJ);
        }
    }
}
