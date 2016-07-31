using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comp2007_Assignment2.Models;

namespace Comp2007_Assignment2.Controllers
{
    [Authorize]
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        [AllowAnonymous]
        public ActionResult Index()
        {
            List<Models.Type> type = new List<Models.Type>
             {
        new Models.Type ("Fire"),
        new Models.Type ("Water"),
        new Models.Type ("Grass")
    };
            return View(type);
        }
        //
        // GET: /Store/Browse?dish=
        [AllowAnonymous]
        public ActionResult Browse(string type)
        {
            {
                Models.Type typeModel = new Models.Type (type);
                return View(typeModel);
            }
        }
        // GET: /Store/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id = 1)
        {
            Dish dish = new Dish("Dish " + id);
            return View(dish);
        }
    }
}