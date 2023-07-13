using Convertor_Class_Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
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
            try
            {

                string fileName = "Codes.json";
                string folderPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Conversion_Codes");

                string filePath = System.IO.Path.Combine(folderPath, fileName);

                string json = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(json))
                {
                    dynamic jsonObject = JsonConvert.DeserializeObject(json);
                    if (jsonObject != null && jsonObject.supported_codes != null)
                    {
                        List<List<string>> supportedCodes = jsonObject.supported_codes.ToObject<List<List<string>>>();

                        foreach (List<string> codeList in supportedCodes)
                        {
                            if (codeList.Count > 0)
                            {
                                string code = codeList[0];
                                string name = codeList[1];
                                string itemText = $"{code}, {name}";
                                FirstCurrency.Items.Add(itemText);
                                SecondCurrency.Items.Add(itemText);
                            }
                        }
                    }
                }
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
            string selectedItem = (string)FirstCurrency.SelectedItem;
            firstSelectedCurrency = selectedItem.Substring(0, 3);
        }

        private void SecondCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = (string)SecondCurrency.SelectedItem;
            secondSelectedCurrency = selectedItem.Substring(0, 3);
        }

        private void InputAmount_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            InputAmount.Text = string.Empty;
        }
    }
}
