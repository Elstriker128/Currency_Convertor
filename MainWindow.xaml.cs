using Convertor_Class_Library;
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

namespace Currency_Convertor
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
        private void ApiPlacement_GotKeyboardFocus(object sender, RoutedEventArgs e)
        {
            ApiPlacement.Clear();
        }

        private void ApiPlacement_LostKeyboardFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ApiPlacement.Text))
            {
                ApiPlacement.Text = "Input your API key";
            }
        }
        private async void ActivationButton_Click(object sender, RoutedEventArgs e)
        {
            string ApiKey = ApiPlacement.Text;
            bool valid = await ApiHelper.CheckIfApiValid(ApiKey);
            if (valid)
            {
                InvalidKey.Visibility = Visibility.Hidden;
                ApiHelper.InitializeClient(ApiKey);
                ConversionInfo conversion = new ConversionInfo();
                conversion.Show();
            }
            else
            {
                InvalidKey.Visibility = Visibility.Visible;
                ApiPlacement.Text = string.Empty;
            }
        }
    }
}
