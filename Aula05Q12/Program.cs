using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q12
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero, int maiUm)
        {
            return num + outroNumero + maiUm;
        }
        public static int Subtracao(this int num, int outroNumero)
        {
            return num - outroNumero;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            Console.WriteLine(numero.Soma(3, 4));
            Console.WriteLine(numero.Subtracao(10));
            Console.WriteLine(2.Soma(20, 1));
            Console.WriteLine(2.Subtracao(20));
        }
    }
}
