using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Client.Design
{
    class DesignProductService : ProductService.IProductService
    {
        private readonly List<Product> products = new List<Product>();

        public DesignProductService()
        {
            products.Add(new Product()
            {
                Id = 1,
                Name = "Морковка",
                Price = 2.5,
                Quantity = 12530,
                Location = Location.InStock
            });

            products.Add(new DomainModel.Product()
            {
                Id = 2,
                Name = "Картошка",
                Price = 4.75,
                Quantity = 11320,
                Location = Location.Absent
            });
        }

        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductList()
        {
            return products.ToArray();
        }

        public Task<Product[]> GetProductListAsync()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
