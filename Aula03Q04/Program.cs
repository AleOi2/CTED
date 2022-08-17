using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Q04
{
    public class Animal
    {
        public string Nome { get; set; }
        public Animal(string nome) { Nome = nome; }
    }
    public class Cachorro : Animal
    {
        public double Altura  { get; set; }
        public Cachorro(string nome):base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializando");
        }
        public Cachorro(string nome, double altura) : base(nome)
        {
            Altura = altura;
        }
        public override string ToString()
        {
            return $"Cachorro {Nome} tem {Altura} de altura";
        }
    }

    public class Golden : Cachorro
    {
        public Golden(string nome) : base(nome)
        {
            Console.WriteLine($"Golden {nome} inicializando");
        }
        public Golden(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }
        public override string ToString()
        {
            return $"Golden {Nome} tem {Altura} de altura";
        }
    }

    internal class Program
    {
        public static void Main()
        {
            var spike = new Cachorro("spike");
            var max = new Cachorro("Max", 40.0);
            var nina = new Golden("Nina", 50.0);
            Console.WriteLine(max);
            Console.WriteLine(nina);
            Console.ReadLine();
        }

    }

}
