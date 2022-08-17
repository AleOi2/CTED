using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q09
{
    internal class Program
    {
        delegate double Raiz(double a, double b);
        static double RaizQuadrada(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        static void Main(string[] args)
        {
            //Func<double, double, double> raiz = (a, b) =>
            //{
            //    return Math.Sqrt(a * a + b * b);
            //};
            Raiz calculaRaiz = RaizQuadrada;
            Console.WriteLine(calculaRaiz(3,4));
                        
        }
    }
}
