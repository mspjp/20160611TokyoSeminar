using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NativeSample
{
    public class MyClass
    {
        public MyClass()
        {
        }

        public static async Task<String> GetSearchResult(String str)
        {
            var httpClient = new HttpClient();
            var url = "https://raw.githubusercontent.com/xamarin/xamarin-" + str + "/master/README.md";
            return await httpClient.GetStringAsync(url);
        }
    }
}