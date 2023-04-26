using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Nodes;
using yugioh_card_search.Models;
using static yugioh_card_search.Models.CardModel;

namespace yugioh_card_search.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetCard(string search)
        {
            var root = GetCardInfo(search);
            Console.WriteLine(root);
            return View(root);
        }

        public Rootobject GetCardInfo(string searchTerm) 
        {
            try 
            {
                var client = new HttpClient();
                var ygoURL = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?fname={searchTerm}";
                var ygoResponse = client.GetStringAsync(ygoURL).Result;
                Rootobject rootObject = JsonConvert.DeserializeObject<Rootobject>(ygoResponse);
                return rootObject;
            } catch (Exception ex) 
            {
                // Handle the exception here, for example by logging the error or returning a default value
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}