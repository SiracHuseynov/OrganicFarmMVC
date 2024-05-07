using Microsoft.AspNetCore.Mvc;
using OrganicFarmMVC.DAL;
using OrganicFarmMVC.Models;
using OrganicFarmMVC.ViewModels;

namespace OrganicFarmMVC.Controllers
{
    public class PageController : Controller
    {

        private readonly AppDbContext _dbContext;

        public PageController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult BlogGrid()
        {
            return View();
        }
        public IActionResult BlogDetail()
        {
            return View();
        }

        public IActionResult Features()
        {
            return View();
        }

        public IActionResult TheTeam()
        {
            //Farmer farmer1 = new Farmer
            //{
            //    Fullname = "Nezrin Abdullayeva",
            //    Designation = "Farmer1",
            //    InstagramLink = "www.instagram.com/nazrin",
            //    FacebookLink = "www.facebook.com/nazrin",
            //    LinkedinLink = "www.linkedin.com/nazrin",
            //    XLink = "www.x.com/nazrin",
            //    Image = "team-2.jpg"
            //};

            //Farmer farmer2 = new Farmer
            //{
            //    Fullname = "Ismail Kartal",
            //    Designation = "Farmer2",
            //    InstagramLink = "www.instagram.com/ismayil",
            //    FacebookLink = "www.facebook.com/ismayil",
            //    LinkedinLink = "www.linkedin.com/ismayil",
            //    XLink = "www.x.com/ismayil",
            //    Image = "team-1.jpg"
            //};

            //Farmer farmer3 = new Farmer
            //{
            //    Fullname = "Elvin Ceferquliyev",
            //    Designation = "Farmer3",
            //    InstagramLink = "www.instagram.com/Elvin",
            //    FacebookLink = "www.facebook.com/Elvin",
            //    LinkedinLink = "www.linkedin.com/Elvin",
            //    XLink = "www.x.com/Elvin",
            //    Image = "team-3.jpg"
            //};

            //Farmer farmer4 = new Farmer
            //{
            //    Fullname = "Lamiye Mahmudova",
            //    Designation = "Farmer1",
            //    InstagramLink = "www.instagram.com/Lamiye",
            //    FacebookLink = "www.facebook.com/Lamiye",
            //    LinkedinLink = "www.linkedin.com/naLamiyezrin",
            //    XLink = "www.x.com/Lamiye",
            //    Image = "team-2.jpg"
            //};

            //Farmer farmer5 = new Farmer
            //{
            //    Fullname = "Qurban Qurbanov",
            //    Designation = "Farmer2",
            //    InstagramLink = "www.instagram.com/Qurban",
            //    FacebookLink = "www.facebook.com/Qurban",
            //    LinkedinLink = "www.linkedin.com/Qurban",
            //    XLink = "www.x.com/Qurban",
            //    Image = "team-1.jpg"
            //};

            //Farmer farmer6 = new Farmer
            //{
            //    Fullname = "Behlul Mustafazada",
            //    Designation = "Farmer3",
            //    InstagramLink = "www.instagram.com/Behlul",
            //    FacebookLink = "www.facebook.com/Behlul",
            //    LinkedinLink = "www.linkedin.com/Behlul",
            //    XLink = "www.x.com/Behlul",
            //    Image = "team-3.jpg"
            //};

            //List<Farmer> farmers = new List<Farmer>() { farmer1, farmer2, farmer3, farmer6, farmer4, farmer5};
            //_dbContext.Farmers.AddRange(farmers);
            //_dbContext.SaveChanges();

            //return View(farmers);

            PageVM pageVm = new PageVM()
            {
                Farmers = _dbContext.Farmers.ToList()
            };

            return View(pageVm);
        }

        public IActionResult Testimonial()
        {
            return View();
        }

    }
}
