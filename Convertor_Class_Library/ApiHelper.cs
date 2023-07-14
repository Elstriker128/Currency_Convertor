using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Convertor_Class_Library
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }
        public static async Task<bool> CheckIfApiValid(string ApiKey)
        {
            try
            {
                ApiClient = new HttpClient();
                ApiClient.DefaultRequestHeaders.Accept.Clear();
                ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await ApiClient.GetAsync($"https://v6.exchangerate-api.com/v6/{ApiKey}/pair/EUR/GBP/1");

                return response.IsSuccessStatusCode;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ApiClient.DefaultRequestHeaders.Clear();
                ApiClient.Dispose();
            }

        }
        public static void InitializeClient(string ApiKey)
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri($"https://v6.exchangerate-api.com/v6/{ApiKey}/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
