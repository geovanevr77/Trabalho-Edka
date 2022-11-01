using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa07 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o primeiro número:");
            string xStr = Console.ReadLine();
            Console.WriteLine("Digite o segundo número:");
            string yStr = Console.ReadLine();
            Console.WriteLine();
            int x = Convert.ToInt32(xStr);
            int y = Convert.ToInt32(yStr);
            int r = x + y;

            Console.WriteLine("O resultado é: ");
            Console.WriteLine(r.ToString());
        }

        private static int Somar(int x, int y) {
            
            return x + y;
        }
    }
}
