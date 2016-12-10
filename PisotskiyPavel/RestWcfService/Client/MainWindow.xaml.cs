using DomainModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Users = new ObservableCollection<User>();
            
            listView.ItemsSource = Users;
        }

        public ObservableCollection<User> Users
        {
            get;
            private set;
        }

        private void UpdateDataButton_Click(object sender, RoutedEventArgs e)
        {
            Users.Clear();
            WebRequest request = WebRequest.Create("http://localhost:49864/UserService/Users");

            string cre = String.Format("{0}:{1}", "testuser", "testpassword");

            byte[] bytes = Encoding.ASCII.GetBytes(cre);
            string base64 = Convert.ToBase64String(bytes);

            request.Headers.Add("Authorization", "Basic " + base64);
            WebResponse ws = request.GetResponse();
            DataContractJsonSerializer s = new DataContractJsonSerializer(typeof(IEnumerable<User>));
            IEnumerable<User> users = (IEnumerable<User>)s.ReadObject(ws.GetResponseStream());
            foreach (User user in users)
            {
                Users.Add(user);
            }
        }

        private void listView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                User selectedUser = listView.SelectedItems[0] as User;
                if(selectedUser != null)
                {
                    WebRequest request = WebRequest.Create($"http://localhost:49864/UserService/Users/{selectedUser.Id}");

                    string cre = String.Format("{0}:{1}", "testuser", "testpassword");

                    byte[] bytes = Encoding.ASCII.GetBytes(cre);
                    string base64 = Convert.ToBase64String(bytes);

                    request.Headers.Add("Authorization", "Basic " + base64);

                    WebResponse ws = request.GetResponse();
                    DataContractJsonSerializer s = new DataContractJsonSerializer(typeof(User));
                    User user = (User)s.ReadObject(ws.GetResponseStream());
                    MessageBox.Show(user.Name);
                }
            }
        }
    }
}
