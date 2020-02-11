using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CatName { get; set; }

        public string CatDesc { get; set; }

        public List<Product> Products { get; set; }
    }
}
