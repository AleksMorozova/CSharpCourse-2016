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
    /// <summary>
    /// Interaction logic for EditProductWindow.xaml
    /// </summary>
    public partial class EditProductWindow : Window, IDisposable
    {
        public EditProductWindow(Product product)
        {
            InitializeComponent();
            ((EditProductViewModel)this.DataContext).SelectedProduct = product;
            Messenger.Default.Register<Messege>(this, CloseEditProductWindow);
        }

        public void Dispose()
        {
            Messenger.Default.Unregister(this);
        }

        private void CloseEditProductWindow(Messege obj)
        {
            if(obj == Messege.CloseEditProductWindow)
            {
                this.Close();
            }
        }
    }
}
