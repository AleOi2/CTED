using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroTeste
{
    class MinhaClasse
    {
        public int valor;
        public MinhaClasse(int valor)
        {
            this.valor = valor;
        }
    }



    internal class Program
    {
        static int calculaVolumeDoCubo(int len)
        {
            return len * len * len;
        }
        static Tuple<int, int, int> RetornoMultiplo(int len)
        {
            return new Tuple<int,int,int>(len, len, len);
        }

        static void Main(string[] args)
        {
            int volume= calculaVolumeDoCubo(22);
            float valor = 20.2f;
            int valor2 = (int) valor;
            Console.WriteLine($"Primeiro {valor2} teste de C#");
            Console.WriteLine("Primeiro" + $"{valor2}" + "teste de C#");
            Console.WriteLine("Primeiro {0} teste de C#", valor2);
            var (teste1, teste2, teste3) = RetornoMultiplo(25);
            Console.WriteLine("Teste1: {0} \nTeste2: {1} \nTeste3: {2}", teste1, teste2, teste3);
            MinhaClasse minhclasse = new MinhaClasse(22);
            Console.WriteLine("Valor da classe: {0}", minhclasse?.valor);

            // Ponteiro:
            int numero1;
            string palavra = Console.ReadLine();
            int.TryParse(palavra, out numero1);
            
            Console.WriteLine("Resultado 1: {0}", numero1);
            //Console.WriteLine(valorImportante?.Length);
            //string valorImportante = null;
            //Console.WriteLine(valorImportante?.Length);
            double peso = 91.233;
            double altura = 20;
            double imc = peso/Math.Pow(altura, 2);

            if ( imc < 16 )
            {
                Console.WriteLine($"{peso.ToString("0.##")} Baixo Peso Grau 3");
            } else if (imc >= 16 && imc <= 16.99)
            {
                Console.WriteLine($"{peso.ToString("0.##")} Baixo Peso Grau w");

            } else if (imc >= 17 && imc <= 18.49)
            {
                Console.WriteLine($"{peso.ToString("0.##")} Baixo Peso Grau 1");

            } else if (imc >= 18.5 && imc <= 24.99)
            {
                Console.WriteLine($"{peso.ToString("0.##")} Peso Ideal");

            }else if (imc >= 25 && imc <= 29.99)
            {
                Console.WriteLine($"{peso.ToString("0.##")} Sobrepeso");

            } else if (imc >= 30 && imc <= 34.99)
            {
                Console.WriteLine($"{peso.ToString("0.##")} Obesidade Grau 1");

            } else if (imc >= 35 && imc <= 39.99)
            {
                Console.WriteLine($"{peso.ToString("0.##")} Obesidade Grau 2");

            } else if (imc >= 4)
            {
                Console.WriteLine($"{peso.ToString("0.##")} Obesidade Grau 3");

            }
            Console.WriteLine($"{peso.ToString("N", 2)}");
            Console.ReadLine();
        }
    }
}
