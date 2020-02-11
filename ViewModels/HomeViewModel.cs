using OnlineShopCart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> favProducts { get; set; }
    }
}
