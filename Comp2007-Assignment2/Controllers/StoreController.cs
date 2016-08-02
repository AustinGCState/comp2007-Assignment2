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

        PokemonBytesContext storeDB = new PokemonBytesContext();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Comp2007_Assignment2.Models.Type> type = storeDB.Types.ToList(); 
            return View(type);
        }
        //
        // GET: /Store/Browse?dish=
 
        public ActionResult Browse(string type)
        {
            if(type == null){
                type = "Water";
            }
            {
                Models.Type typeModel = storeDB.Types.Include("Dishes").Single(t => t.Name == type);
                return View(typeModel);
            }
        }
        // GET: /Store/Details/5

        public ActionResult Details(int id = 1)
        {
            Dish dish = storeDB.Dishes.Find(id);
            return View(dish);
        }
    }
}