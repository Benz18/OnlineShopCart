using OnlineShopCart.Data.Interfaces;
using OnlineShopCart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Data.Mocks
{
    public class MockAllProducts : IAllProducts
    {
        private readonly IProductCategory catProduct = new MockProductCategory();
        public IEnumerable<Product> Products 
        {
            get 
            {
                return new List<Product>
                {
                    new Product { Name = "Doom 1", ShortDesc = "D1", LongDesc = "____Doom 1____", Img = "/img/doom1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.First()},
                    new Product { Name = "Doom 2", ShortDesc = "D2", LongDesc = "____Doom 2____", Img = "/img/doom1.jpg", Price = 20, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.First()},
                    new Product { Name = "Doom 3", ShortDesc = "D3", LongDesc = "____Doom 3____", Img = "/img/doom1.jpg", Price = 30, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.First()},
                    new Product { Name = "Doom 2016", ShortDesc = "D2016", LongDesc = "____Doom 2016____", Img = "/img/doom1.jpg", Price = 40, IsFavourite = true, Avaliable = true, Category = catProduct.AllCategories.First()},
                    new Product { Name = "Doom Eternal", ShortDesc = "DE", LongDesc = "____Doom Eternal____", Img = "/img/doom1.jpg", Price = 50, IsFavourite = false, Avaliable = false, Category = catProduct.AllCategories.First()},
                    new Product { Name = "Quake I", ShortDesc = "QI", LongDesc = "____Quake I____", Img = "/img/quake1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(1)},
                    new Product { Name = "Quake II", ShortDesc = "QII", LongDesc = "____Quake II____", Img = "/img/quake1.jpg", Price = 20, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(1)},
                    new Product { Name = "Quake III Arena", ShortDesc = "QIIIA", LongDesc = "____Quake III Arena____", Img = "/img/quake1.jpg", Price = 30, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(1)},
                    new Product { Name = "Quake IV", ShortDesc = "QIV", LongDesc = "____Quake IV____", Img = "/img/quake1.jpg", Price = 40, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(1)},
                    new Product { Name = "Quake Live", ShortDesc = "QL", LongDesc = "____Quake Live____", Img = "/img/quake1.jpg", Price = 50, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(1)},
                    new Product { Name = "Quake Champions", ShortDesc = "QC", LongDesc = "____Quake Champions____", Img = "/img/quake1.jpg", Price = 60, IsFavourite = true, Avaliable = true, Category = catProduct.AllCategories.ElementAt(1)},
                    new Product { Name = "Unreal", ShortDesc = "U", LongDesc = "____Unreal____", Img = "/img/unreal1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(2)},
                    new Product { Name = "Unreal 2: The Awakening", ShortDesc = "U2:TA", LongDesc = "____Unreal 2: The Awakening____", Img = "/img/unreal1.jpg", Price = 20, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(2)},
                    new Product { Name = "Unreal Tournament", ShortDesc = "UT", LongDesc = "____Unreal Tournament____", Img = "/img/unreal1.jpg", Price = 30, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(2)},
                    new Product { Name = "Unreal Tournament 2004", ShortDesc = "UT2004", LongDesc = "____Unreal Tournament 2004____", Img = "/img/unreal1.jpg", Price = 40, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(2)},
                    new Product { Name = "Unreal Tournament III", ShortDesc = "UTIII", LongDesc = "____Unreal Tournament III____", Img = "/img/unreal1.jpg", Price = 50, IsFavourite = true, Avaliable = true, Category = catProduct.AllCategories.ElementAt(2)},
                    new Product { Name = "Unreal Tournament IV", ShortDesc = "UTIV", LongDesc = "____Unreal Tournament IV____", Img = "/img/unreal1.jpg", Price = 60, IsFavourite = false, Avaliable = false, Category = catProduct.AllCategories.ElementAt(2)},
                    new Product { Name = "Half-Life", ShortDesc = "HL", LongDesc = "____Half-Life____", Img = "/img/half-life1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.ElementAt(3)},
                    new Product { Name = "Half-Life 2", ShortDesc = "HL2", LongDesc = "____Half-Life 2____", Img = "/img/half-life1.jpg", Price = 20, IsFavourite = true, Avaliable = true, Category = catProduct.AllCategories.ElementAt(3)},
                    new Product { Name = "Counter-Strike", ShortDesc = "CS", LongDesc = "____Counter-Strike____", Img = "/img/counter-strike1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.Last()},
                    new Product { Name = "Counter-Strike: Condition Zero", ShortDesc = "CS:CZ", LongDesc = "____Counter-Strike: Condition Zero____", Img = "/img/counter-strike1.jpg", Price = 20, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.Last()},
                    new Product { Name = "Counter-Strike: Condition Zero Deleted Scenes", ShortDesc = "CS:CZDE", LongDesc = "____Counter-Strike: Condition Zero Deleted Scenes____", Img = "/img/counter-strike1.jpg", Price = 30, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.Last()},
                    new Product { Name = "Counter-Strike: Source", ShortDesc = "CS:S", LongDesc = "____Counter-Strike: Source____", Img = "/img/counter-strike1.jpg", Price = 40, IsFavourite = false, Avaliable = true, Category = catProduct.AllCategories.Last()},
                    new Product { Name = "Counter-Strike: Global Offensive", ShortDesc = "CS:GO", LongDesc = "____Counter-Strike: Global Offensive____", Img = "/img/counter-strike1.jpg", Price = 50, IsFavourite = true, Avaliable = true, Category = catProduct.AllCategories.Last()},
                };
            }
        }
        public IEnumerable<Product> FavProducts { get; set; }

        public Product GetObjProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
