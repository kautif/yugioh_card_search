using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using yugioh_card_search;

namespace yugioh_card_search {
    public class Program
    {
        public static void Main(string[] args)
        {
           /*( var client = new HttpClient();
            var ygoURL = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?fname=dragon";
            var ygoResponse = client.GetStringAsync(ygoURL).Result;
            var ygoJSON = JsonObject.Parse(ygoResponse)["data"].ToString();
            Console.WriteLine(ygoJSON);*/

            string connectionKey = File.ReadAllText("appsettings.json");
            JObject jsonObject = JObject.Parse(connectionKey);
            JToken token = jsonObject["DefaultConnection"];
            // string connString = token.ToString();
            // ProductRepo.connectionString = connString;


            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
