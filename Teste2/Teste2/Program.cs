using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            this.memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            this.memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar(int a)
        {
            this.memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
    };


    internal class Program
    {
        // Like a Lambda
        static void Teste2() => Console.WriteLine("Entrando no teste 2");

        int a = 42;

        //public static int getA()
        //{
        //    static int aStatic = this.a;
        //    return aStatic;
        // }

        static void Main(string[] args)
        {
            //Console.WriteLine("Segundo Dia de testes");
            //string[] alunos = { "Alexandre", "Caio"};
            //foreach(string aluno in alunos)
            //{
            //    Console.WriteLine(aluno);
            //}
            //var palavra = "Oi";
            //foreach (var letra in palavra)
            //{
            //    Console.WriteLine(letra);
            //}
            //Teste2();
            Pessoa primeiraPessoa = new Pessoa("Alexandre", 22);
            // CalculadoraCadeia calculadora = new CalculadoraCadeia();
            //calculadora.Somar(32).Imprimir();
            //Console.WriteLine("Verificando inicio");
            //getA();
            // Console.WriteLine(getA());
            Console.ReadLine();

        }
    }
}

