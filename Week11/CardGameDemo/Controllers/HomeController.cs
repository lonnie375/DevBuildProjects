using CardGameDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CardGameDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //public static string DeckId = ""; We started here but this caused issues
        //We only had one deck shared across all users of our site. 
        // Lets give each user their own deck 
        //instead of keeping a single, static deck it, we'll 
        // pass it around through our views and links 
        // static public string DeckID= "";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //Old Way________________________
            //HttpClient web = new HttpClient();
            //web.BaseAddress = new Uri("https://www.deckofcardsapi.com/");
            //var connection = await web.GetAsync($"api/deck/new/shuffle/?deck_count=1");
            //CardResponse resp = await connection.Content.ReadAsAsync<CardResponse>();
            ////DeckId = resp.deck_id; //We are just storing the deck id so that we can use it in the future 

            ////Calling the other api that we want. This feeds off of the original one as well 
            //connection = await web.GetAsync($"api/deck/{resp.deck_id}/draw/?count=5"); //We are getting 5 cards from the deck here 
            //resp = await connection.Content.ReadAsAsync<CardResponse>();
            //return View(resp);

            string deck_id = await CardAPI.GetNewDeck();
            CardResponse resp = await CardAPI.GetCards(deck_id, 5);
            return View(resp);
        }

        public async Task<IActionResult> DrawFive(string deck_id)
        {
            
            HttpClient web = new HttpClient();
            web.BaseAddress = new Uri("https://www.deckofcardsapi.com/");
            var connection = await web.GetAsync($"api/deck/{deck_id}/draw/?count=5"); ;
            if (connection.StatusCode.ToString() == "notfound")
            {
                return Content(connection.RequestMessage.RequestUri.OriginalString);
            }
            CardResponse resp = await connection.Content.ReadAsAsync<CardResponse>();
            return View("index", resp);


            //new
            //CardResponse resp = await CardAPI.GetCards(deck_id, 5);
            //return View("index", resp);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}