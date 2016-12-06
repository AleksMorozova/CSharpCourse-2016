﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ProductService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductService.IProductService")]
    public interface IProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/Create", ReplyAction="http://tempuri.org/IProductService/CreateResponse")]
        void Create(DomainModel.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/Create", ReplyAction="http://tempuri.org/IProductService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(DomainModel.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/Delete", ReplyAction="http://tempuri.org/IProductService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/Delete", ReplyAction="http://tempuri.org/IProductService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProduct", ReplyAction="http://tempuri.org/IProductService/GetProductResponse")]
        DomainModel.Product GetProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProduct", ReplyAction="http://tempuri.org/IProductService/GetProductResponse")]
        System.Threading.Tasks.Task<DomainModel.Product> GetProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProductList", ReplyAction="http://tempuri.org/IProductService/GetProductListResponse")]
        DomainModel.Product[] GetProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/GetProductList", ReplyAction="http://tempuri.org/IProductService/GetProductListResponse")]
        System.Threading.Tasks.Task<DomainModel.Product[]> GetProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/Update", ReplyAction="http://tempuri.org/IProductService/UpdateResponse")]
        void Update(DomainModel.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProductService/Update", ReplyAction="http://tempuri.org/IProductService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(DomainModel.Product product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductServiceChannel : Client.ProductService.IProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<Client.ProductService.IProductService>, Client.ProductService.IProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Create(DomainModel.Product product) {
            base.Channel.Create(product);
        }
        
        public System.Threading.Tasks.Task CreateAsync(DomainModel.Product product) {
            return base.Channel.CreateAsync(product);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public DomainModel.Product GetProduct(int id) {
            return base.Channel.GetProduct(id);
        }
        
        public System.Threading.Tasks.Task<DomainModel.Product> GetProductAsync(int id) {
            return base.Channel.GetProductAsync(id);
        }
        
        public DomainModel.Product[] GetProductList() {
            return base.Channel.GetProductList();
        }
        
        public System.Threading.Tasks.Task<DomainModel.Product[]> GetProductListAsync() {
            return base.Channel.GetProductListAsync();
        }
        
        public void Update(DomainModel.Product product) {
            base.Channel.Update(product);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(DomainModel.Product product) {
            return base.Channel.UpdateAsync(product);
        }
    }
}
