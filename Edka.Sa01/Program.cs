using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa01 {
    internal class Program {
        static void Main(string[] args) {
            int idade1 = 27;
            int idade2 = 52;
            int idade3 = 70;
            int idade4 = 25;
            int idade5 = 39;

            Console.WriteLine("A média é: "+
                Convert.ToDouble(idade1+idade2+idade3+idade4
                +idade5)/5);

            Console.ReadKey();
        }
        
    }
}
