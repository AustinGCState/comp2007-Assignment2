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

        public virtual int DishID { get; set; }

        public virtual string PokemonId { get; set; }

        public virtual string Name { get; set; }

        public virtual double Price { get; set; }

        public virtual string DishImageUrl { get; set; }

        public virtual Type Types { get; set; }

        public virtual Pokemon Pokemon { get; set; }

    }
}