using Microsoft.AspNetCore.Mvc;
using PokerGame.Models;
using System.Diagnostics;

namespace PokerGame.Controllers
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

        public async Task<IActionResult> DrawFive(string name, string name2)
        {   //Create a new Deck
            string deck_id = await CardAPI.GetNewDeck(); 
            //Create an instance of PokerHands 
            PokerHands poker = new PokerHands();
            //Draw 5 cards for user 1
            Hand user1 = await CardAPI.GetHand(deck_id, 5);
            user1.username = name; 
            poker.player1 = user1; 
            //Draw 5 cards for user
            Hand user2 = await CardAPI.GetHand(deck_id, 5);
            user2.username = name2; 
            poker.player2 = user2;
 
            // And display ten cards and the name of the winner
            return View(poker);
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