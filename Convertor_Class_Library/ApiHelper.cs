using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Convertor_Class_Library
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient(string ApiKey)
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri($"https://v6.exchangerate-api.com/v6/{ApiKey}/pair/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
