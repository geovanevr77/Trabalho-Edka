using Edka.Sa6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOEdka.Sa6 {
    class Program {
        static void Main(string[] args) {

            PessoaFisica pf = new PessoaFisica();
            pf.Codigo = 2724;
            pf.Nome = "Geovane";
            pf.CPF = "023.456.789-10";

            pf.Mostrar();
            Console.WriteLine("________________________________");

            PessoaJuridica pj = new PessoaJuridica();
            pj.Codigo = 3567;
            pj.Nome = "New Project";
            pj.CNPJ = "68.895.586/0005-41";

            pj.Mostrar();

            Console.ReadKey();

        }
    }
}