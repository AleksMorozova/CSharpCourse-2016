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
    class EditProductViewModel : BaseViewModel
    {
        private readonly ProductService.IProductService productService;
        private Product product;
        public Product SelectedProduct
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        public EditProductViewModel(ProductService.IProductService productService)
        {
            this.productService = productService;
        }

        public IEnumerable<Location> Locations
        {
            get { return (IEnumerable<Location>)Enum.GetValues(typeof(Location)); }
        }

        #region EditProductCommand
        private RelayCommand editProductCommand;

        public ICommand EditProductCommand
        {
            get
            {
                if (editProductCommand == null)
                    editProductCommand = new RelayCommand(EditProductCommandExecute, EditProductCommandCanExecute);
                return editProductCommand;
            }
        }

        private void EditProductCommandExecute(object obj)
        {
            productService.Update(SelectedProduct);
            Messenger.Default.Send<Messege>(Messege.CloseEditProductWindow);
        }

        private bool EditProductCommandCanExecute(object obj)
        {
            return SelectedProduct != null && !string.IsNullOrEmpty(SelectedProduct.Name) && SelectedProduct.Price > 0;
        }
        #endregion


        #region CloseEditProductWindowCommand
        private RelayCommand closeEditProductWindowCommand;

        public ICommand CloseEditProductWindowCommand
        {
            get
            {
                if (closeEditProductWindowCommand == null)
                    closeEditProductWindowCommand = new RelayCommand(CloseEditProductWindowCommandExecute);
                return closeEditProductWindowCommand;
            }
        }

        private void CloseEditProductWindowCommandExecute(object obj)
        {
            Messenger.Default.Send<Messege>(Messege.CloseEditProductWindow);
        }
        #endregion
    }
}
