using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Segundo Dia de testes");
            string[] alunos = { "Alexandre", "Caio"};
            foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            var palavra = "Oi";
            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            Console.ReadLine();

        }
    }
}
