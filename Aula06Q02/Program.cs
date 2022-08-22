using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Q02
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override bool Equals(object obj)
        {
            var produto = obj as Produto;
            return produto != null && Nome == produto.Nome && Preco == produto.Preco;
        }

        //public override int GetHashCode()
        //{
        //    var hashCode = -347481536;
        //    hashCode = hashCode * (-1521134295) + EqualityComparer<string>.Default.GetHashCode(this.Nome);
        //    hashCode = hashCode * (-1521134295) + Preco.GetHashCode();
        //    return hashCode;
        //}
    }

    class ColecoesList
    {
        static void Main(string[] vars)
        {
            var livro = new Produto("Game of Thrones", 49.9);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);
            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8 temporada", 99.9),
                new Produto("Poster", 29.9),
            };
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach(var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro)); 
        }
    }

}
