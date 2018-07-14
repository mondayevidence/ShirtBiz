using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShirtBiz.Controllers
{
    class WebService
    {
        private static readonly HttpClient client = new HttpClient();

        private string BaseUrl = "https://jsonplaceholder.typicode.com/";

        public async Task<string> GetRequest(string url)
        {
            var ResponseString = "very present";
            try
            {
                var response = await client.GetAsync(BaseUrl + url);
                Debug.WriteLine(BaseUrl + url);
                ResponseString = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(ResponseString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return ResponseString;

        }

        private static readonly HttpClient clientPost = new HttpClient();

       /* private string BaseUrlPost = "https://chikini-moni.firebaseio.com/employes/";

        public async Task<string> PostRequest(string url, Dictionary<string, string> formvalues)
        {
            var ResponseString = "it is present";
            try
            {
                var content = new FormUrlEncodedContent(formvalues);
                var response = await clientPost.PostAsync(url, content);
                ResponseString = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(ResponseString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return ResponseString;
        }*/
    }
}
