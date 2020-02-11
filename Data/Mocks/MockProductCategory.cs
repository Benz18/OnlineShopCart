using OnlineShopCart.Data.Interfaces;
using OnlineShopCart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Data.Mocks
{
    public class MockProductCategory : IProductCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CatName = "Doom", CatDesc = "The great mf of first person shooters" },
                    new Category { CatName = "Quake", CatDesc = "Rj all the way" },
                    new Category { CatName = "Unreal", CatDesc = "An \"Epic\" arena shooter" },
                    new Category { CatName = "Half-Life", CatDesc = "Rise and shine, mr. Freeman" },
                    new Category { CatName = "Counter-Strike", CatDesc = "A mod that become legendary" }
                };
            }
        }
    }
}
