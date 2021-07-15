using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace TestPostAsJsonAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            await client.PostAsJsonAsync(
                "https://webhook.site/265de048-0b91-4d6b-be7d-16cbf209ff05",
                new { ClientIP = "127.0.0.1" });
        }
    }
}
