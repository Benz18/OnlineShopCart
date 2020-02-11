using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using OnlineShopCart.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCart.Data
{
    public class DbObjects
    {
        public static void Initial(AppDbContent content)
        {
            //AppDbContent content = app.ApplicationServices.GetRequiredService<AppDbContent>();

            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Product.Any())
            {
                content.AddRange(
                    new Product { Name = "Doom 1", ShortDesc = "D1", LongDesc = "____Doom 1____", Img = "/img/doom1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = Categories["Doom"] },
                    new Product { Name = "Doom 2", ShortDesc = "D2", LongDesc = "____Doom 2____", Img = "/img/doom1.jpg", Price = 20, IsFavourite = false, Avaliable = true, Category = Categories["Doom"] },
                    new Product { Name = "Doom 3", ShortDesc = "D3", LongDesc = "____Doom 3____", Img = "/img/doom1.jpg", Price = 30, IsFavourite = false, Avaliable = true, Category = Categories["Doom"] },
                    new Product { Name = "Doom 2016", ShortDesc = "D2016", LongDesc = "____Doom 2016____", Img = "/img/doom1.jpg", Price = 40, IsFavourite = true, Avaliable = true, Category = Categories["Doom"] },
                    new Product { Name = "Doom Eternal", ShortDesc = "DE", LongDesc = "____Doom Eternal____", Img = "/img/doom1.jpg", Price = 50, IsFavourite = false, Avaliable = false, Category = Categories["Doom"] },
                    new Product { Name = "Quake I", ShortDesc = "QI", LongDesc = "____Quake I____", Img = "/img/quake1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = Categories["Quake"] },
                    new Product { Name = "Quake II", ShortDesc = "QII", LongDesc = "____Quake II____", Img = "/img/quake1.jpg", Price = 20, IsFavourite = false, Avaliable = true, Category = Categories["Quake"] },
                    new Product { Name = "Quake III Arena", ShortDesc = "QIIIA", LongDesc = "____Quake III Arena____", Img = "/img/quake1.jpg", Price = 30, IsFavourite = false, Avaliable = true, Category = Categories["Quake"] },
                    new Product { Name = "Quake IV", ShortDesc = "QIV", LongDesc = "____Quake IV____", Img = "/img/quake1.jpg", Price = 40, IsFavourite = false, Avaliable = true, Category = Categories["Quake"] },
                    new Product { Name = "Quake Live", ShortDesc = "QL", LongDesc = "____Quake Live____", Img = "/img/quake1.jpg", Price = 50, IsFavourite = false, Avaliable = true, Category = Categories["Quake"] },
                    new Product { Name = "Quake Champions", ShortDesc = "QC", LongDesc = "____Quake Champions____", Img = "/img/quake1.jpg", Price = 60, IsFavourite = true, Avaliable = true, Category = Categories["Quake"] },
                    new Product { Name = "Unreal", ShortDesc = "U", LongDesc = "____Unreal____", Img = "/img/unreal1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = Categories["Unreal"] },
                    new Product { Name = "Unreal 2: The Awakening", ShortDesc = "U2:TA", LongDesc = "____Unreal 2: The Awakening____", Img = "/img/unreal1.jpg", Price = 20, IsFavourite = false, Avaliable = true, Category = Categories["Unreal"] },
                    new Product { Name = "Unreal Tournament", ShortDesc = "UT", LongDesc = "____Unreal Tournament____", Img = "/img/unreal1.jpg", Price = 30, IsFavourite = false, Avaliable = true, Category = Categories["Unreal"] },
                    new Product { Name = "Unreal Tournament 2004", ShortDesc = "UT2004", LongDesc = "____Unreal Tournament 2004____", Img = "/img/unreal1.jpg", Price = 40, IsFavourite = false, Avaliable = true, Category = Categories["Unreal"] },
                    new Product { Name = "Unreal Tournament III", ShortDesc = "UTIII", LongDesc = "____Unreal Tournament III____", Img = "/img/unreal1.jpg", Price = 50, IsFavourite = true, Avaliable = true, Category = Categories["Unreal"] },
                    new Product { Name = "Unreal Tournament IV", ShortDesc = "UTIV", LongDesc = "____Unreal Tournament IV____", Img = "/img/unreal1.jpg", Price = 60, IsFavourite = false, Avaliable = false, Category = Categories["Unreal"] },
                    new Product { Name = "Half-Life", ShortDesc = "HL", LongDesc = "____Half-Life____", Img = "/img/half-life1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = Categories["Half-Life"] },
                    new Product { Name = "Half-Life 2", ShortDesc = "HL2", LongDesc = "____Half-Life 2____", Img = "/img/half-life1.jpg", Price = 20, IsFavourite = true, Avaliable = true, Category = Categories["Half-Life"] },
                    new Product { Name = "Counter-Strike", ShortDesc = "CS", LongDesc = "____Counter-Strike____", Img = "/img/counter-strike1.jpg", Price = 10, IsFavourite = false, Avaliable = true, Category = Categories["Counter-Strike"] },
                    new Product { Name = "Counter-Strike: Condition Zero", ShortDesc = "CS:CZ", LongDesc = "____Counter-Strike: Condition Zero____", Img = "/img/counter-strike1.jpg", Price = 20, IsFavourite = false, Avaliable = true, Category = Categories["Counter-Strike"] },
                    new Product { Name = "Counter-Strike: Condition Zero Deleted Scenes", ShortDesc = "CS:CZDE", LongDesc = "____Counter-Strike: Condition Zero Deleted Scenes____", Img = "/img/counter-strike1.jpg", Price = 30, IsFavourite = false, Avaliable = true, Category = Categories["Counter-Strike"] },
                    new Product { Name = "Counter-Strike: Source", ShortDesc = "CS:S", LongDesc = "____Counter-Strike: Source____", Img = "/img/counter-strike1.jpg", Price = 40, IsFavourite = false, Avaliable = true, Category = Categories["Counter-Strike"] },
                    new Product { Name = "Counter-Strike: Global Offensive", ShortDesc = "CS:GO", LongDesc = "____Counter-Strike: Global Offensive____", Img = "/img/counter-strike1.jpg", Price = 50, IsFavourite = true, Avaliable = true, Category = Categories["Counter-Strike"] }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CatName = "Doom", CatDesc = "The great mf of first person shooters" },
                        new Category { CatName = "Quake", CatDesc = "Rj all the way" },
                        new Category { CatName = "Unreal", CatDesc = "An \"Epic\" arena shooter" },
                        new Category { CatName = "Half-Life", CatDesc = "Rise and shine, mr. Freeman" },
                        new Category { CatName = "Counter-Strike", CatDesc = "A mod that become legendary" }
                    };

                    category = new Dictionary<string, Category>();

                    foreach(Category element in list)
                    {
                        category.Add(element.CatName, element);
                    }
                }

                return category;
            }
        }
    }
}
