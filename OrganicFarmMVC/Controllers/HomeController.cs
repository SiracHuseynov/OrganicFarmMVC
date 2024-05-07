using Microsoft.AspNetCore.Mvc;

namespace OrganicFarmMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
