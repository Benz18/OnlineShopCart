using OnlineShopCart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> AllProducts { get; set; }

        public string CurrentCategory { get; set; }

    }
}
