using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using OnlineShopCart.Data.Interfaces;
using OnlineShopCart.Data.Models;
using OnlineShopCart.ViewModels;

namespace OnlineShopCart.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAllProducts _allProducts;

        private readonly IProductCategory _allCategories;

        public ProductController(IAllProducts iAllProducts, IProductCategory iAllCategories)
        {
            _allProducts = iAllProducts;
            _allCategories = iAllCategories;
        }

        [Route("Products/List")]
        [Route("Products/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products = null;
            string currentCategory = "";

            if(string.IsNullOrEmpty(category))
            {
                products = _allProducts.Products.OrderBy(i => i.Id);
            }
            else 
            {
                if(string.Equals("Doom", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(i => i.Category.CatName.Equals("Doom")).OrderBy(i => i.Id);
                    currentCategory = "Doom Franchise";
                }
                else if (string.Equals("Quake", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(i => i.Category.CatName.Equals("Quake")).OrderBy(i => i.Id);
                    currentCategory = "Quake Franchise";
                }
                else if (string.Equals("Unreal", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(i => i.Category.CatName.Equals("Unreal")).OrderBy(i => i.Id);
                    currentCategory = "Unreal Franchise";
                }
                else if (string.Equals("Half-Life", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(i => i.Category.CatName.Equals("Half-Life")).OrderBy(i => i.Id);
                    currentCategory = "Half-Life Franchise";
                }
                else if (string.Equals("Counter-Strike", category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _allProducts.Products.Where(i => i.Category.CatName.Equals("Counter-Strike")).OrderBy(i => i.Id);
                    currentCategory = "Counter-Strike Franchise";
                }

                //currentCategory = _category;
            }

            var productObj = new ProductListViewModel
            {
                AllProducts = products,
                CurrentCategory = currentCategory
            };

            ViewBag.Title = "Games shopping cart";

            // ViewBag.Category = "First Person Shooters";
            // var products = AllProducts.Products;
            // return View(products);
            // ProductListViewModel obj = new ProductListViewModel();
            // obj.AllProducts = _allProducts.Products;
            // obj.CurrentCategory = "First Person Shooters";
            //return View(obj);

            return View(productObj);
        }
    }
}
