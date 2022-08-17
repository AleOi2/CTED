using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q10
{

    internal class Program
    {
        delegate string StringOperacao(string s);
        static void Main(string[] args)
        {
            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
                //return "Verificando";
            };
            Console.WriteLine(inverter("C# é diferente"));
        }
    }
}
