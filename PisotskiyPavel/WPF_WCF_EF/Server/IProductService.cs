using DomainModel;
using System.Collections.Generic;
using System.ServiceModel;

namespace Server
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        void Create(Product product);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        IEnumerable<Product> GetProductList();
        
        [OperationContract]
        void Update(Product product);
    }
}