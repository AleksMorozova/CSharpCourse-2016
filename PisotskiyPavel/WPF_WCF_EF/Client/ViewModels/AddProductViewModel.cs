using Client.Common;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.ViewModels
{
    class AddProductViewModel : BaseViewModel
    {
        private readonly ProductService.IProductService productService;

        public AddProductViewModel(ProductService.IProductService productService)
        {
            this.productService = productService;
        }

        private Product product = new Product();

        public Product Product
        {
            get { return product; }
        }

        public IEnumerable<Location> Locations
        {
            get { return (IEnumerable<Location>)Enum.GetValues(typeof(Location)); }
        }

        #region AddProductCommand
        private RelayCommand addProductCommand;

        public ICommand AddProductCommand
        {
            get
            {
                if (addProductCommand == null)
                    addProductCommand = new RelayCommand(AddProductCommandExecute, AddProductCommandCanExecute);
                return addProductCommand;
            }
        }

        private bool AddProductCommandCanExecute(object obj)
        {
            return !string.IsNullOrEmpty(product.Name) && product.Price > 0;
        }

        private void AddProductCommandExecute(object obj)
        {
            productService.Create(product);
            Messenger.Default.Send<Messege>(Messege.CloseAddProductWindow);
        }
        #endregion

        #region CloseAddProductWindowCommand
        private RelayCommand closeAddProductWindowCommand;

        public ICommand CloseAddProductWindowCommand
        {
            get
            {
                if (closeAddProductWindowCommand == null)
                    closeAddProductWindowCommand = new RelayCommand(CloseAddProductWindowCommandExecute);
                return closeAddProductWindowCommand;
            }
        }

        private void CloseAddProductWindowCommandExecute(object obj)
        {
            Messenger.Default.Send<Messege>(Messege.CloseAddProductWindow);
        }
        #endregion
    }
}
