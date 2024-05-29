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

namespace 과제10_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            txtDisplay.Text += button.Content.ToString();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = string.Empty;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
