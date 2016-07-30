using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comp2007_Assignment2.Models;

namespace Comp2007_Assignment2.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
             List<Types> type= new List<Types>
             {
        new Types ("Fire"),
        new Types ("Water"),
        new Types ("Grass")
    };
            return View(type);
        }
        //
        // GET: /Store/Browse?dish=pizza
        public ActionResult Browse(string type)
        {
            {
                Types typeModel = new Models.Types (type);
                return View(typeModel);
            }
        }
        // GET: /Store/Details/5
        public ActionResult Details(int id = 1)
        {
            Dish dish = new Dish("Dish " + id);
            return View(dish);
        }
    }
}