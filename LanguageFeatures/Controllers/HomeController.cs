using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeatures.Models;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "navigate to a url to show an example";
        }

        public ViewResult AutoProperty()
        {
            Product myProduct=new Product();
            myProduct.Name = "Kayak";
            string productName = myProduct.Name;
            return View("Result", (object) $"Product name:{productName}");
        }

        public ViewResult CreateProduct()
        {
            Product myProduct=new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 275M,
                Category = "Watersports"
        };
            return View("Result",(object)$"Category:{myProduct.Category}");
        }

        public ViewResult CreateCollection()
        {
            string[] stringArray = {"apple", "orage", "plum"};
            List<int> intList=new List<int> {10,20,30,40};
            Dictionary<string,int> myDict=new Dictionary<string, int>
            {
                {"apple",10 }, {"orange",20 }, {"plum",30 }
            };
            return View("Result", (object) stringArray[1]);
        }

        public ViewResult UseExtension()
        {
            ShoppingCart cart=new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product {Name="Kayal",Price=49.95M },
                    new Product {Name="Corner flag",Price=34.95M },
                    new Product {Name="Soccer ball",Price = 19.50M}
                }
            };
            decimal cartTotal = cart.TotalPrices();
            return View("UseExtension", (object) $"Total:{cartTotal:c}");
        }
    }
}