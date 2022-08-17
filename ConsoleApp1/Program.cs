using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao  }

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nacimento;
        public Genero GeneroDoFilme;
        public Cliente(string nome, DateTime nacimento)
        {
            Nome = nome;
            Nacimento = nacimento;
            Nacimento = new DateTime(2020,10,10);
        }
        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nacimento.Day, Nacimento.Month, Nacimento.Year);

        }
    }

    class ReadOnly
    {
        static void Funcaoteste(int valor1, int valor3)
        {
            Console.WriteLine(valor1);
            Console.WriteLine(valor3);
        }
        static void Main(string[] args)
        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
            Funcaoteste(valor3: 1, valor1: 22);
            Console.WriteLine(Genero.Acao);
            Console.ReadLine();
        }
    }
}