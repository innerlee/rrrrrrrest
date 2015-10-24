using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace rrrrrrrest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://tagger.chinacloudsites.cn");
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest();
            request.Method = Method.POST;
            request.Resource = "SwipeCard/Check";

            IRestResponse response = client.Execute(request);
            Console.Write(response.Content == "1" ? "open" : "closed");
        }
    }
}

