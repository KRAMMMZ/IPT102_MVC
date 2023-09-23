using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DEMO.Models;

namespace DEMO.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            
            
            List<ItemList> IList = new List<ItemList>()
        {
            new ItemList {ID=1, Name="Monkey D. Luffy", Age=19, Role="Captain", Fruit="Hito Hito No Mi", Bounty=3000000000 },
            new ItemList {ID=2, Name="Roronoa Zoro", Age=21, Role="Swordsman", Fruit="No Devil Fruit", Bounty=1111000000 },
            new ItemList {ID=3, Name="Vinsmoke Sanji", Age=21, Role="Chef", Fruit="No Devil Fruit", Bounty=1032000000 },
            new ItemList {ID=4, Name="Jimbei", Age=46, Role="Helmsman", Fruit="No Devil Fruit", Bounty=1100000000 },
            new ItemList {ID=5, Name="Nico Robin", Age=31, Role="Archaeologist", Fruit="Hana Hana No Mi", Bounty=930000000 },
            new ItemList {ID=6, Name="Usopp", Age=21, Role="Sniper", Fruit="No Devil Fruit", Bounty=500000000 },
            new ItemList {ID=7, Name="Franky", Age=36, Role="Shipwright", Fruit="No Devil Fruit", Bounty=394000000 },
            new ItemList {ID=8, Name="Brook", Age=90, Role="Musician/Swordsman", Fruit="Yomi Yomi No Mi", Bounty=383000000 },
            new ItemList {ID=9, Name="Nami", Age=20, Role="Navigator", Fruit="No Devil Fruit", Bounty=366000000 },
            new ItemList {ID=10, Name="Tony Tony Chopper", Age=17, Role="Doctor", Fruit="Hito Hito No Mi", Bounty=1000 },

        };
            return View(IList);
        }
    }
}