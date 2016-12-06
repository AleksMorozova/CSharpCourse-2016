using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Repositories
{
    class ProductRepository : IRepository<Product>
    {
        private readonly ApplicationContext context;

        public ProductRepository()
        {
            context = new ApplicationContext();
        }

        public void Create(Product product)
        {
            context.Products.Add(product);
        }

        public void Delete(int id)
        {
            Product product = context.Products.Find(id);
            if (product != null)
                context.Products.Remove(product);
        }

        public Product GetItem(int id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> GetItemsList()
        {
            return context.Products;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
        }
    }
}
