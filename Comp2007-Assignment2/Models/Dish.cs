using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp2007_Assignment2.Models
{
    public class Dish
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Dish() {
            
            }

        /// <summary>
        /// This Constructor takes one parameter - Pokemon
        /// </summary>
        /// <param name="Pokemon"></param>
        public Dish(String Pokemon) {

            this.Pokemon = Pokemon;
        }

        public int DishID { get; set; }

        public string Pokemon { get; set; }

        public Type Types { get; set; }

    }
}