using GraphqlProject.Models;
using System.Collections.Generic;

namespace GraphqlProject.Interfaces
{
    public interface IProduct
    {
        List<Product> GetAllProducts();
        Product AddProduct(Product product);
        Product UpdateProduct(int id, Product product);
        void DeleteProduct(int id);
        Product GetproductById(int id);
    }
}
