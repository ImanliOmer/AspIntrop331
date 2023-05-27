using Microsoft.AspNetCore.Mvc;

namespace PP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name = "Omar";
            ViewBag.Surname = "Imanov";
            ViewBag.Age = 19;
            ViewData["Country"] = "Azerbaijan";
            ViewData["Number"] = "+994555355255";
            return View();
        }
    }
}