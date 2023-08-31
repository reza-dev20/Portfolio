using Microsoft.AspNetCore.Mvc;
using PortfolioMVC.Models;
using System.Diagnostics;

namespace PortfolioMVC.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(ILogger<HomeController> logger)
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact() {
            var contact = new Contact();
            return View(contact);
        }

        //[HttpPost]
        //public IActionResult Contact(IFormCollection form) {
        //    return Json(NotFound());
        //}
        public IActionResult Contact(Contact contact) 
        {

            return View(contact);
        }


/*        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}