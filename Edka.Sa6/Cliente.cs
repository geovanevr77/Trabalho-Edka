using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOEdka.Sa6 {
     class Cliente {

        public int Codigo;

        public string Nome;

        public void Mostrar() {
            Console.WriteLine("Dados do cliente: {0}---{1}", Codigo, Nome);
        }
    }
}
