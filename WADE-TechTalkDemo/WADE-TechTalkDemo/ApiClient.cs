using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WADE_TechTalkDemo
{
    public class ApiClient
    {
        protected readonly HttpClient HttpClient;

        protected ApiClient(string apiUrl)
        {
            HttpClient = new HttpClient() { BaseAddress = new Uri(apiUrl) };
        }

        protected ApiClient(string apiUrl, HttpClientHandler httpClientHandler)
        {
            HttpClient = new HttpClient(httpClientHandler) { BaseAddress = new Uri(apiUrl) };
        }

        public string GetBaseUrl()
        {
            return HttpClient?.BaseAddress.ToString();
        }
    }
}
