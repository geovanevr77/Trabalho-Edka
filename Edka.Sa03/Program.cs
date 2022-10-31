using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa03 {
    internal class Program {
        static void Main(string[] args) {

            //1. Fonte de dados (vetor, matrix, collections, .XLS, .XML, .TXT, .CSV, .DAT, .SQL)
            //A fonte escolhida será um vetor.


            int[] votos = new int[10] 
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                5,
                5,
                7
            };

            //2. Consulta: Query Sintax. LINQ

            var consulta = from voto in votos select voto;

            //3. Executando Consulta
            //Listando com foreach
            foreach (int voto in votos) 
            {
                Console.WriteLine(voto);
            }
            //Listando com ToList()
            /*var votosFiltrados = consulta.ToList();
            Console.WriteLine($"Votos filtrados: {votosFiltrados.ToString()}");*/

            Console.ReadKey();


        }
    }
}
