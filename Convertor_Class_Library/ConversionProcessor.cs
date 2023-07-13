using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Convertor_Class_Library
{
    public class ConversionProcessor
    {
        public static async Task<ConversionModel> LoadConversion(string baseCode, string targetCode, decimal inputAmount)
        {
            //string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/pair/{baseCode}/{targetCode}/{inputAmount}";
            using(HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"pair/{baseCode}/{targetCode}/{inputAmount}/"))
            {
                if(response.IsSuccessStatusCode)
                {
                    ConversionModel conversionModel = await response.Content.ReadAsAsync<ConversionModel>();

                    return conversionModel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
