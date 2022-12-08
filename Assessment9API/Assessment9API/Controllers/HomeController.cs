using Assessment9API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assessment9API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            MyList list = await CharacterAPI.GetSpecificCharacter(); 
            return View(list);  
        }
        //public async Task<IActionResult> GetSpecificCharacter()
        //{
        //    HttpClient web = new HttpClient();
        //    web.BaseAddress = new Uri("https://anapioficeandfire.com/api/");

        //    var connection = await web.GetAsync($"characters/823");
        //    Character chars1 = await connection.Content.ReadAsAsync<Character>();

        //    var connection2 = await web.GetAsync($"characters/2");
        //    Character chars2 = await connection2.Content.ReadAsAsync<Character>();

        //    var connection3 = await web.GetAsync($"characters/216");
        //    Character chars3 = await connection3.Content.ReadAsAsync<Character>();

        //    var connection4 = await web.GetAsync($"characters/217");
        //    Character chars4 = await connection4.Content.ReadAsAsync<Character>();
        //    var connection5 = await web.GetAsync($"characters/400");
        //    Character chars5 = await connection5.Content.ReadAsAsync<Character>();

        //    //Add to your list of characters 
        //    MyList myList = new MyList();
        //    myList.list.Add(chars1);
        //    myList.list.Add(chars2);
        //    myList.list.Add(chars3);
        //    myList.list.Add(chars4);
        //    myList.list.Add(chars5);
            
        //    return View(myList);


        //}

        

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