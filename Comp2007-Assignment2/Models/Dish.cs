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
        public Dish(String PokemonId) {

            this.PokemonId = PokemonId;
        }

        public int DishID { get; set; }

        public string PokemonId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string DishImageUrl { get; set; }

        public Type Types { get; set; }

        public Pokemon Pokemon { get; set; }

    }
}