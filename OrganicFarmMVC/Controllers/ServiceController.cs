using Microsoft.AspNetCore.Mvc;

namespace OrganicFarmMVC.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
