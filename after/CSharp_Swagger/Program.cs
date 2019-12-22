using swagger;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace CSharp_Swagger
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IMyAPI myAPI = new MyAPI(new Uri("http://localhost:5000/"));
            var weathers = await myAPI.GetWeatherForecastAsync();
            var json = JsonSerializer.Serialize(weathers);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
