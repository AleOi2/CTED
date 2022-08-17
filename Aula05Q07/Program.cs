using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q07
{
    delegate double Operacao(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacao soma = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;
            Console.WriteLine(soma(2,5));
            Console.WriteLine(sub(2, 5));
            Console.WriteLine(mult(2, 5));
            Console.ReadLine();
        }
    }
}
