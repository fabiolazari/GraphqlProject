using GraphqlProject.Data;
using GraphqlProject.Interfaces;
using GraphqlProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphqlProject.Services
{
    public class ProductService : IProduct
    {
        private GraphQLDbContext _dbContext;

        public ProductService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private static List<Product> products = new List<Product>()
        {
            new Product() { Id = 0, Name="Coffee", Price = 10 },
            new Product() { Id = 1, Name="Tea", Price = 15 }
        };

        public List<Product> GetAllProducts()
        {
            //return Produtcs;
            return _dbContext.Products.ToList();
        }

        public Product GetproductById(int id)
        {
            //return products.Find(p => p.Id == id);
            return _dbContext.Products.Find(id);
        }

        public Product AddProduct(Product product)
        {
            //products.Add(product);
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            //products[id] = product;
            var productObj = _dbContext.Products.Find(id);
            productObj.Name = product.Name;
            productObj.Price = product.Price;
            _dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            //products.RemoveAt(id);
            var productObj = _dbContext.Products.Find(id);
            _dbContext.Products.Remove(productObj);
            _dbContext.SaveChanges();
        }
    }
}
