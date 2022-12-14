using accessing_db.Interfaces;
using accessing_db.Models;
using System.Data.SqlClient;

namespace accessing_db.Repositories
{
    internal class ProductRepository : IProduct
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly string stringConexao = "Server=labsoft.pcs.usp.br; Initial Catalog=db_27 ; User id=usuario_27; pwd=41183548885;";
        //private readonly string stringConexao = "Data source=MP\\SQLEXPRESS; Initial Catalog=Catalog; integrated security=true;";

        public void Create(Product newProduct)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = $"INSERT INTO Products (IdProduct, Name, Description, Price) VALUES ('{newProduct.IdProduct}', '{newProduct.Name}', '{newProduct.Description}', {newProduct.Price})";
                // SQL Injection

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(string idProduct)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReadAll()
        {
            List<Product> listProducts = new();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelect = "SELECT * FROM Products";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Product product = new()
                        {
                            IdProduct =         rdr["IdProduct"].ToString(),
                            Name =              rdr[1].ToString(),
                            Description =       rdr[2].ToString(),
                            Price =             Convert.ToDecimal(rdr[3])
                        };

                        listProducts.Add(product);
                    }
                }
            }

            return listProducts;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
