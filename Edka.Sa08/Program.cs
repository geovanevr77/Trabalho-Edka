using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema;


namespace Edka.Sa08 {
    class Program {
        static void Main(string[] args) {

            SistemaBanco conta = new SistemaBanco(TipoConta.ContaCorrente, "123456");
            Console.WriteLine("Mostrar saldo: ");
            conta.Num = "123";
            conta.Depositar(800);
            conta.Sacar(300);
            Console.WriteLine(conta.GetSaldo().ToString());
            Console.ReadLine();
           
            
         
        }
    }
}
