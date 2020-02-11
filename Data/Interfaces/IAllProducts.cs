using OnlineShopCart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Data.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; }

        IEnumerable<Product> FavProducts { get; }

        Product GetObjProduct(int productId);
    }
}
