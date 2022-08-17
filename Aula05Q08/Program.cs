using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q08
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void imprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.9));
            imprimirSoma op2 = MeuImprimirSoma;
            op2(5.4, 8);
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5,3));
            Action<double, double> op4 = MeuImprimirSoma;
            op4(7.7, 23.4);
            
        }

    }
}
