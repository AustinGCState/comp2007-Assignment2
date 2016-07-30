using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Comp2007_Assignment2.Models
{
    public class PokemonBytesContext : DbContext
    {
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Dish> Dish { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }

    }
}