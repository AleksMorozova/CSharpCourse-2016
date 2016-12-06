using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.Contracts
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
        void Save();

        [OperationContract]
        void Update(Product product);
    }
}
