using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace OgrenciServisTakip.Business
{
    public static class WebApiSettings
    {
        public static HttpClient webApiClient = new HttpClient();

        static WebApiSettings()
        {
            webApiClient.BaseAddress = new Uri("http://localhost:58188/api/");
            webApiClient.DefaultRequestHeaders.Clear();
            webApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}