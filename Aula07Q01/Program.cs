using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Q01
{
    internal class Program
    {
        public const string absPath = "C:/Users/curso/source/repos/Aula07Q01/";
        static void Main(string[] args)
        {
            Console.WriteLine("Verificando fim");
            //Base.CreateFolderFile(absPath + "teste/teste.txt");
            //Product produto = new Product(1, "camiseta", "Camiseta com goma", 20);
            //produto.createProduct(produto);
            Product produto = new Product();

            string option;
            do
            {
                Console.WriteLine("Escolha uma das opcoes");
                Console.WriteLine("1 - Listar produtos");
                Console.WriteLine("2 - Cadastrar produto");
                Console.WriteLine("3 - Editar produto");
                Console.WriteLine("4 - Deletar produtos");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        if (produto.readAllProducts().Count == 0)
                        {
                            Console.WriteLine("Não há produtos cadastrados");
                        }
                        else
                        {
                            var productList = produto.readAllProducts();
                            Console.WriteLine("Lista de produtos");
                            foreach (var item in productList)
                            {
                                Console.WriteLine(${ item.IdProduct});
                            }

                        }

                        break;
                    case "2":
                        Product produto = new Product(1, "camiseta", "Camiseta com goma", 20);
                        produto.createProduct(produto);

                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            } while (option != "0");
        }
    }
}
