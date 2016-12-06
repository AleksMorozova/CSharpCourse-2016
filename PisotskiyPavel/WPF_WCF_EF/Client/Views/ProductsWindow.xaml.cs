using Client.Common;
using Client.ViewModels;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client.Views
{

    public partial class ProductsWindow : Window, IDisposable
    {
        public ProductsWindow()
        {
            InitializeComponent();
            Messenger.Default.Register<Messege>(this, ShowAddProductWindow);
            Messenger.Default.Register<Action<bool>>(this, ConfirmationRemoveProduct, "ConfirmationRemoveProduct");
            Messenger.Default.Register<Product>(this, ShowEditProductWindow, Messege.ShowEditProductWindow);
        }

        private void ShowEditProductWindow(Product product)
        {
            EditProductWindow window = new EditProductWindow(product);
            window.Owner = this;
            window.ShowDialog();
        }

        private void ConfirmationRemoveProduct(Action<bool> messageAction)
        {
            var result = MessageBox.Show("Удалить данный продукт?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            messageAction(result == MessageBoxResult.Yes);
        }

        private void ShowAddProductWindow(Messege message)
        {
            if (message == Messege.ShowAddProductWindow)
            {
                AddProductWindow window = new AddProductWindow();
                window.Owner = this;
                window.ShowDialog();
            }
        }

        public void Dispose()
        {
            Messenger.Default.Unregister(this);
            Messenger.Default.Unregister(this, "ConfirmationRemoveProduct");
        }
    }
}
