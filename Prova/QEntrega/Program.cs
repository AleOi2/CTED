using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QEntrega
{
    public class Program
    {
        public static string ConvertToHex(string inputword)
        {
            string result = "";
            int stringCounter = 0;
            foreach (var c in inputword)
            {
                int asc = c;
                Func<int, string> conversorHex = (numero) => {
                    return numero.ToString("x");
                };
                result += conversorHex(c);
                if (!(stringCounter == inputword.Length))
                {
                    result += " ";

                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            string conversor = ConvertToHex("hello world");
            Console.WriteLine(conversor);
        }

    }


}
