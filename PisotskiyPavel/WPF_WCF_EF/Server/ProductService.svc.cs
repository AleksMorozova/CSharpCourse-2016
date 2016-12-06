using DomainModel;
using Server.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public void Create(Product product)
        {
            productRepository.Create(product);
            productRepository.Save();
        }

        public void Delete(int id)
        {
            productRepository.Delete(id);
            productRepository.Save();
        }

        public Product GetProduct(int id)
        {
            return productRepository.GetItem(id);
        }

        public IEnumerable<Product> GetProductList()
        {
            return productRepository.GetItemsList();
        }
        
        public void Update(Product product)
        {
            productRepository.Update(product);
            productRepository.Save();
        }
    }
}
