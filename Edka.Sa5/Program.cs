using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa05 {
    internal class Program {

        public static List<Disciplina> disciplina = new List<Disciplina>
        {
            new Disciplina{Materia="Neurociência e aprendizagem",Inicio=new DateTime(2022,08,08), Termino= new DateTime(2022,09,12)},
            new Disciplina{Materia="Habilidade socio emocionais",Inicio=new DateTime(2022,08,10), Termino= new DateTime(2022,08,24)},
            new Disciplina{Materia="Felicidade",Inicio=new DateTime(2022,08,31), Termino= new DateTime(2022,09,14)},
            new Disciplina{Materia="Teoria de Desenvolvimento humano e da aprendizagem",Inicio=new DateTime(2022,09,19), Termino= new DateTime(2022,10,24)},
            new Disciplina{Materia="Planejamento Pedagógico",Inicio=new DateTime(2022,08,27), Termino= new DateTime(2022,10,23)},
            new Disciplina{Materia="Educação inclusiva e Cidadania",Inicio=new DateTime(2022,09,21), Termino= new DateTime(2022,11,09)},
            new Disciplina{Materia="Gestão da Sala de Aula",Inicio=new DateTime(2022,11,16), Termino= new DateTime(2022,12,30)},
            new Disciplina{Materia="Met. Dinâmicas e Inovativas",Inicio=new DateTime(2022,10,31), Termino= new DateTime(2022,11,14)},
            new Disciplina{Materia="Projeto Integrador",Inicio=new DateTime(2022,11,21), Termino= new DateTime(2022,12,05)},
            new Disciplina{Materia="Avaliação Por Competências",Inicio=new DateTime(2023,01,01), Termino= new DateTime(2023,01,02)},
            new Disciplina{Materia="Aprendizagem por Competências",Inicio=new DateTime(2023,01,02), Termino= new DateTime(2023,01,03)},
            new Disciplina{Materia="Prática Docente à Distância",Inicio=new DateTime(2023,01,03), Termino= new DateTime(2023,01,04)},
            new Disciplina{Materia="Lesgislação e diretrizes da Educação Profissional e tecnológica",Inicio=new DateTime(2023,01,04), Termino= new DateTime(2023,01,05)},
            new Disciplina{Materia="Ambiente de Aprendizagem Inovativos",Inicio=new DateTime(2023,01,05), Termino= new DateTime(2023,01,06)}

        };

        static void Main(string[] args) {

            var entradaDeDados = from d in disciplina orderby d.Inicio descending select d;
            foreach (var dados in entradaDeDados) 
            {
                Console.WriteLine(dados);
                //Console.ReadKey();
            }
        }
    }
}
