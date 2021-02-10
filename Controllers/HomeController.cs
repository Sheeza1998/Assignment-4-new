using Assignment_4__new_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4__new_.Controllers
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

            List<string> RestaurantList = new List<string>();
            //returning the array
            foreach(Restaurant R in Restaurant.GetRestaurants())
            {
                #nullable enable
                string? Fav_Dish = R.Fav_Dish;
                string? Phone = R.Phone;
                string? Website = R.Website;

                RestaurantList.Add($"#{R.Ranking}:{R.Name} {Fav_Dish} {R.Address} {Phone} {Website}");

            }
            return View(RestaurantList);
        }


        //suggestions page
        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestions(Suggestions suggestions)
        {

            Display.AddSuggestions(suggestions);
            return RedirectToAction("Submissions");
        }

        public IActionResult Submissions()
        {
            return View(Display.suggestions_added_public);
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
