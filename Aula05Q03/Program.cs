using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05Q03
{
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }
    class Soma : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }
    }
    class Subtracao: OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }
    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(), new Subtracao(), new Multiplicacao()
        };
        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";
            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name}  = {op.Operacao(a, b)} \n";
            }
            return resultado;

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        Calculadora calculadora = new Calculadora();
        string resultado = calculadora.ExecutarOperacoes(10, 30);
        Console.WriteLine(resultado);
        Console.ReadLine();


        }
    }
}
