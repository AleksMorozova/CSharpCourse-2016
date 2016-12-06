using Client.Common;
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
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window, IDisposable
    {
        public AddProductWindow()
        {
            InitializeComponent();
            Messenger.Default.Register<Messege>(this, CloseAddProductWindow);
        }

        public void Dispose()
        {
            Messenger.Default.Unregister(this);
        }

        private void CloseAddProductWindow(Messege message)
        {
            if (message == Messege.CloseAddProductWindow)
            {
                this.Close();
            }
        }
    }
}
