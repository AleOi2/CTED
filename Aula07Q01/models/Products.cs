using Aula07Q01.Iterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Q01
{
    public class Product : Base , IProduct
    {
        public int IdProduct { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        private const string path = Program.absPath + "database/products.csv";
        public Product()
        {
            CreateFolderFile(path);

        }

        public Product(int Id, string Name, string Description, decimal Price)
        {
            this.IdProduct = Id;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }

        private static string PrepareLineCSV(Product product){
            return $"{product.IdProduct};{product.Name};{product.Description};{product.Price};";
        }

        public void createProduct(Product produto)
        {
            string[] line = { PrepareLineCSV(produto) };
            Console.WriteLine("Verificando path");
            Console.WriteLine(path);
            File.AppendAllLines(path, line);
        }

        public List<Product> readAllProducts()
        {
            List<Product> products = new List<Product>();
            string[] lines = File.ReadAllLines(path);
            foreach (var item in lines)
            {
                string[] strings = item.Split(';');
                Product product = new Product(
                    int.Parse(strings[0]),
                    strings[1],
                    strings[2],
                    decimal.Parse(strings[3])
                );

                products.Add(product);
            }
            return products;
        }

        public void updateProduct(Product produto)
        {
            throw new NotImplementedException();
        }

        public void deleteProduct(string id)
        {
            throw new NotImplementedException();
        }
    }
}
