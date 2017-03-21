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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyWPFTech
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double number;
        string operId;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void TestedSum()
        {
            number = Convert.ToInt32(textBox.Text);
            textBox.Text = "0";
            operId = "sum";
        }
        public void TestedSub()
        {
            number = Convert.ToInt32(textBox.Text);
            textBox.Text = "0";
            operId = "sub";
        }
        public void TestedMul()
        {
            number = Convert.ToInt32(textBox.Text);
            textBox.Text = "0";
            operId = "mul";
        }

        private void Res_Click(object sender, RoutedEventArgs e)
        {
            switch (operId)
            {
                case "sum":
                    textBox.Text = Convert.ToString(Convert.ToInt32(textBox.Text) + number);
                    break;
                case "sub":
                    textBox.Text = Convert.ToString(-(Convert.ToInt32(textBox.Text)) + number);
                    break;
                case "mul":
                    textBox.Text = Convert.ToString(Convert.ToInt32(textBox.Text) * number);
                    break;
                default:
                    MessageBox.Show("Invalid exeption", "Error message");
                    break;
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
        }
        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            TestedSum();
        }
        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            TestedSub();
        }
        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            TestedMul();
        }        

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "0";
            }
            else
                textBox.Text += "0";
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "1";
            }
            else
                textBox.Text += "1";

        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "2";
            }
            else
                textBox.Text += "2";
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "3";
            }
            else
                textBox.Text += "3";
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "4";
            }
            else
                textBox.Text += "4";
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "5";
            }
            else
                textBox.Text += "5";
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "6";
            }
            else
                textBox.Text += "6";
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "7";
            }
            else
                textBox.Text += "7";
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "8";
            }
            else
                textBox.Text += "8";
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
                textBox.Text = "9";
            }
            else
                textBox.Text += "9";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
