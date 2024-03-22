using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        private List<Product> products;
        public ProductManager()
        {
            products = new List<Product>();
            products.Add(new Product() {ProductId=1,CategoryId=1,Name="Kazak",UnitPrice=400 });
            products.Add(new Product() { ProductId = 2, CategoryId = 1, Name = "Tisort", UnitPrice = 600 });
        }
        public Product Add(Product product)
        {
            products.Add(product);

            return product;
        }

        public void Delete(int id)
        {
            Product product = products.Find(p=> p.ProductId == id);
            if (product == null)
            {
                throw new Exception("Urun bulunamadi");

            }
            
            products.Remove(product);
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            Product product = products.Find(p => p.ProductId == id);
            if (product == null)
            {
                throw new Exception("Urun bulunamadi");

            }

            return product;
        }

        public Product Update(Product product)
        {
            Product checkProduct = products.Find(p => p.ProductId == product.ProductId);
            if (checkProduct == null)
            {
                throw new Exception("Urun bulunamadi");

            }
            checkProduct.Name = product.Name;
            checkProduct.CategoryId = product.CategoryId;
            checkProduct.UnitPrice = product.UnitPrice;

            return checkProduct;

        }
    }
}
