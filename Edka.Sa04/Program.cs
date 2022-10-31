using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa04 {
    internal class Program 
        {

        public static List<Despesa> despesas = new List<Despesa> {

            new Despesa{Descricao = "Internet", Valor = 89, Vencimento = new DateTime(2022,11,15)},
            new Despesa{Descricao = "Luz", Valor = 110, Vencimento = new DateTime(2022,11,07)},
            new Despesa{Descricao = "Água", Valor = 150, Vencimento = new DateTime(2022,11,02)},
            new Despesa{Descricao = "Gasolina", Valor = 230, Vencimento=new DateTime(2022,11,11)},
            new Despesa{Descricao = "Roupas", Valor = 300, Vencimento=new DateTime(2022,11,20)}
        };

        static void Main(string[] args)
        {
            //Filtro LINQ
            //from
            //in
            //select

            var despesasAbaixodeCem = from d in despesas //determina onde deveremos consultar
                                      where d.Valor < 300 // condição
                                      //orderby d.Vencimento //ordem crescente
                                      select d; //selecione

            
            foreach (var item in despesasAbaixodeCem) 
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();
        }
    }
}
