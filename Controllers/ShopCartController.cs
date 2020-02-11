using Microsoft.AspNetCore.Mvc;
using OnlineShopCart.Data.Interfaces;
using OnlineShopCart.Data.Models;
using OnlineShopCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllProducts _productRep;

        private readonly ShopCart _shopCart;

        public ShopCartController(IAllProducts productRep, ShopCart shopCart)
        {
            _productRep = productRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _productRep.Products.FirstOrDefault(i => i.Id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
