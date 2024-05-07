using Microsoft.AspNetCore.Mvc;
using OrganicFarmMVC.DAL;
using OrganicFarmMVC.Models;
using OrganicFarmMVC.ViewModels;

namespace OrganicFarmMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            //Product product1 = new Product
            //{
            //    Fullname = "Tomato",
            //    Image = "product-1.png",
            //    Price = 10
            //};

            //Product product2 = new Product
            //{
            //    Fullname = "Cucumber",
            //    Image = "product-2.png",
            //    Price = 20
            //};

            //Product product3 = new Product
            //{
            //    Fullname = "Potato",
            //    Image = "product-1.png",
            //    Price = 30
            //};

            //Product product4 = new Product
            //{
            //    Fullname = "Cabbage",
            //    Image = "product-2.png",
            //    Price = 40
            //};

            //Product product5 = new Product
            //{
            //    Fullname = "Eggplant",
            //    Image = "product-1.png",
            //    Price = 50
            //};

            //Product product6 = new Product
            //{
            //    Fullname = "Pepper",
            //    Image = "product-2.png",
            //    Price = 60
            //};

            //List<Product> products = new List<Product>() { product1, product2, product3, product4, product5, product6 };
            //_dbContext.Products.AddRange(products);
            //_dbContext.SaveChanges();
            //return View(products);

            ProductVM productVM = new ProductVM()
            {
                Products = _dbContext.Products.ToList()
            };

            return View(productVM);    
        }
    }
}
