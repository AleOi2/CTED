using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Q2
{
    internal class Program
    {
        void MultipleParams(params string[] stringArray)
        {
            maisTeste = "Teste de valor";
            foreach (var text in stringArray)
            {
                Console.WriteLine(text);
            }

        }
        private string teste;
        public string maisTeste { get
            {
                return teste;
            }
            set
            {
                teste = value;
            }
        }

        class ParamatrosporReferencia
        {
            // out = *
            // ref = &
            public static void AlteraRef(ref int numero)
            {
                numero = numero + 100;
            }
            public static void AlterarOut(out int numero1, out int numero2)
            {
                numero1 = 0;
                numero2 = 0;
                numero1 += 15;
                numero2 += 30;
            }

            public static void ValorPadrao(int a = 20)
            {
                Console.WriteLine("O valor padrao vale");
                Console.WriteLine(a);
            }

            static void Main(string[] args)
            {
                //string[] stringArray = new string[5] {"teste1", "teste2", "teste3", "teste4", "teste5" };
                //Program program = new Program();
                //program.MultipleParams(stringArray);
                //Console.WriteLine(program.maisTeste);
                int a = 3;
                AlteraRef(ref a);
                Console.WriteLine(a);

                AlterarOut( out int b, out int c);
                Console.WriteLine($"{b} {c}");
                //out int d = ref e;
                Console.ReadLine();
            }

        }

    }
}
