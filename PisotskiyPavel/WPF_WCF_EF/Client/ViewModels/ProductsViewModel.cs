using Client.Common;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModels
{
    class ProductsViewModel : BaseViewModel
    {
        private readonly ObservableCollection<Product> products = new ObservableCollection<Product>();
        private readonly ProductService.IProductService productService;

        public ProductsViewModel(ProductService.IProductService productService)
        {
            this.productService = productService;
            UpdateData();
        }

        private void UpdateData()
        {
            products.Clear();
            foreach (Product product in productService.GetProductList())
            {
                products.Add(product);
            }
        }

        public ObservableCollection<Product> Products
        {
            get { return products; }
        }

        public Product SelectedProduct { get; set; }
        
        #region OpenAddProductWindowCommand
        private RelayCommand openAddProductWindowCommand;

        public ICommand OpenAddProductWindowCommand
        {
            get
            {
                if (openAddProductWindowCommand == null)
                    openAddProductWindowCommand = new RelayCommand(OpenAddProductWindowCommandExecute);
                return openAddProductWindowCommand;
            }
        }

        private void OpenAddProductWindowCommandExecute(object obj)
        {
            Messenger.Default.Send(Messege.ShowAddProductWindow);
            UpdateData();
        }
        #endregion


        #region RemoveProductCommand
        private RelayCommand removeProductCommand;

        public ICommand RemoveProductCommand
        {
            get
            {
                if (removeProductCommand == null)
                    removeProductCommand = new RelayCommand(RemoveProductCommandExecute, RemoveProductCommandCanExecute);
                return removeProductCommand;
            }
        }

        private bool RemoveProductCommandCanExecute(object obj)
        {
            return SelectedProduct != null;
        }

        private void RemoveProductCommandExecute(object obj)
        {
            Messenger.Default.Send(new Action<bool>(ConfirmationRemoveProduct), "ConfirmationRemoveProduct");
        }
        

        private void ConfirmationRemoveProduct(bool result)
        {
            if (result)
            {
                productService.Delete(SelectedProduct.Id);
                UpdateData();
            }
        }
        #endregion

        #region OpenEditProductWindowCommand
        private RelayCommand openEditProductWindowCommand;

        public ICommand OpenEditProductWindowCommand
        {
            get
            {
                if (openEditProductWindowCommand == null)
                    openEditProductWindowCommand = new RelayCommand(OpenEditProductWindowCommandExecute, OpenEditProductWindowCommandCanExecute);
                return openEditProductWindowCommand;
            }
        }

        private bool OpenEditProductWindowCommandCanExecute(object obj)
        {
            return SelectedProduct != null;
        }

        private void OpenEditProductWindowCommandExecute(object obj)
        {
            Product product = new Product()
            {
                Id = SelectedProduct.Id,
                Name = SelectedProduct.Name,
                Quantity = SelectedProduct.Quantity,
                Price = SelectedProduct.Price,
                Location = SelectedProduct.Location
            };

            Messenger.Default.Send(product, Messege.ShowEditProductWindow);
            UpdateData();
        }
        
        #endregion

    }
}
