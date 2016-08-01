namespace Comp2007_Assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PokemonBytesContext : DbContext
    {
        public PokemonBytesContext()
            : base("name=enterprise2.Enterprise2.0.dbo")
        {
        }

        public virtual DbSet<Dish> Dishs { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Pokemon> Pokemon { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
    }
}
