using Microsoft.AspNetCore.Mvc;

namespace OrganicFarmMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
