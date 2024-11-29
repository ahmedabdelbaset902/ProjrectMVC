using Microsoft.AspNetCore.Mvc;


namespace Restraunt.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }   
}
