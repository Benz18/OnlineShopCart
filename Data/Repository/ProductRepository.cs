using Microsoft.EntityFrameworkCore;
using OnlineShopCart.Data.Interfaces;
using OnlineShopCart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Data.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDbContent appDbContent;

        public ProductRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Product> Products => appDbContent.Product.Include(p => p.Category);

        public IEnumerable<Product> FavProducts => appDbContent.Product.Where(fp => fp.IsFavourite).Include(p => p.Category);

        public Product GetObjProduct(int productId) => appDbContent.Product.FirstOrDefault(fp => fp.Id == productId);
    }
}
