using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Q01.Iterface
{
    public interface IProduct
    {
        //CRUD - Create Read Update Delete
        void createProduct(Product produto);
        List<Product> readAllProducts();
        void updateProduct(Product produto);
        void deleteProduct(string id);

    }
}
