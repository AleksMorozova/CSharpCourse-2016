using DomainModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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
        private AuthenticationToken authenticationToken;

       

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void SignIn_Click(object sender, RoutedEventArgs e)
        {
            var json = new JavaScriptSerializer().Serialize(new { login = login.Text, password = password.Text });

            HttpClient client = new HttpClient();
            var message = await client.PostAsync("http://localhost:49863/Account/SignIn", new StringContent(json, Encoding.UTF8, "application/json"));
            if (message.IsSuccessStatusCode)
            {
                string jsonResult = await message.Content.ReadAsStringAsync();
                authenticationToken = new JavaScriptSerializer().Deserialize<AuthenticationToken>(jsonResult);
                MessageBox.Show("Вы успешно авторизовались как: " + authenticationToken.Login);
            }
            else
            {
                MessageBox.Show(message.StatusCode.ToString());
            }

        }

        private async void ShowData_Click(object sender, RoutedEventArgs e)
        {
            if(authenticationToken == null)
            {
                MessageBox.Show("Извините, но вы не авторизовались. Введите логин и пароль.");
                return;
            }

            var json = new JavaScriptSerializer().Serialize(new { data = "Hello world", authenticationToken = authenticationToken });
            HttpClient client = new HttpClient();
            var message = await client.PostAsync("http://localhost:49863/Data/GetData", new StringContent(json, Encoding.UTF8, "application/json"));
            if (message.IsSuccessStatusCode)
            {
                string jsonResult = await message.Content.ReadAsStringAsync();
                var result = new JavaScriptSerializer().Deserialize<string>(jsonResult);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show(message.StatusCode.ToString());
            }
        }
    }
}
