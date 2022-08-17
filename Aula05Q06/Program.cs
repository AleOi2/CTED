using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda Com C #");
            };
            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random rand = new Random();
                return rand.Next(1, 7);
            };
            Console.WriteLine(jogarDado());
            Func<int, string> conversorHex = (numero) =>
            {
                return numero.ToString("x");
            };

            Func<int, int, int, string> formataData = (dia, mes, ano) =>
            {
                return String.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
            };
            Console.WriteLine(formataData(1,2,1999));
            Console.ReadLine();
        }
    }
}
