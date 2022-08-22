using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06Q03
{
    class ColecoesSet
    {
        static void Main(string[] args)
        {
            var livro = new Produto("Game of thrones",49.9);
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);
            var combo = new HashSet<Produto>
            {
                new Produto();
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
