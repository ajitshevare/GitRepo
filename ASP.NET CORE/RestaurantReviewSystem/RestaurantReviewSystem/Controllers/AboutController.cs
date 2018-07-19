using Microsoft.AspNetCore.Mvc;
using RestaurantReviewSystem.Models;

namespace RestaurantReviewSystem.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View(new RestaurantViewModel());
        }

        [HttpPost]
        public IActionResult Create(RestaurantViewModel model)
        {
            return RedirectToAction(nameof(Details), new { id = 4, name= model.Name});
        }

        public IActionResult Details(int id, string name)
        {
            return View(new RestaurantViewModel { Id=id, Name= name });
        }
    }
}