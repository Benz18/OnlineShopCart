using Microsoft.AspNetCore.Mvc;
using OnlineShopCart.Data.Interfaces;
using OnlineShopCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Controllers
{
    public class HomeController : Controller
    {
        private IAllProducts _productRep;

        public HomeController(IAllProducts productRep)
        {
            _productRep = productRep;
        }

        public ViewResult Index()
        {
            var homeProducts = new HomeViewModel
            {
                favProducts = _productRep.FavProducts
            };

            return View(homeProducts);
        }
    }
}
