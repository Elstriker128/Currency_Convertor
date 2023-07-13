using Convertor_Class_Library;
using Newtonsoft.Json;
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

namespace Currency_Convertor
{
    /// <summary>
    /// Interaction logic for ConversionInfo.xaml
    /// </summary>
    public partial class ConversionInfo : Window
    {
        private string firstSelectedCurrency = string.Empty;
        private string secondSelectedCurrency = string.Empty;
        private decimal inputAmount = 0;
        public ConversionInfo()
        {
            InitializeComponent();
        }

        private async void ConversionButton_Click(object sender, RoutedEventArgs e)
        {
            if(firstSelectedCurrency != string.Empty && secondSelectedCurrency!= string.Empty)
            {
                inputAmount = decimal.Parse(InputAmount.Text);
                var model = await ConversionProcessor.LoadConversion(firstSelectedCurrency,secondSelectedCurrency,inputAmount);
                ResultAmount.Text = model.Conversion_result.ToString();
            }
        }
        private void ExchangeButton_Click(object sender, RoutedEventArgs e)
        {
            string tempCur = firstSelectedCurrency;
            var tempItem = FirstCurrency.SelectedItem;

            firstSelectedCurrency = secondSelectedCurrency;
            secondSelectedCurrency = tempCur;

            FirstCurrency.SelectedItem= SecondCurrency.SelectedItem;
            SecondCurrency.SelectedItem= tempItem;
        }
        private void FirstCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem boxItem = (ComboBoxItem)FirstCurrency.SelectedItem;
            if (boxItem.Content != null)
            {
                firstSelectedCurrency = boxItem.Content.ToString() ?? string.Empty;
            }
        }

        private void SecondCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem boxItem = (ComboBoxItem)SecondCurrency.SelectedItem;
            if (boxItem.Content != null)
            {
                firstSelectedCurrency = boxItem.Content.ToString() ?? string.Empty;
            }
        }
    }
}
