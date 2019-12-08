using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace RedditCommunications
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient;

        public static void InitializeApiClient()
        {
            ApiClient = new HttpClient();
        }
    }
}
