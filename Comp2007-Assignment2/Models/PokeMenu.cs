using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Comp2007_Assignment2.Models
{
    public class Pokemenu : DropCreateDatabaseIfModelChanges<PokemonBytesContext>
    {
        protected override void Seed(PokemonBytesContext context)
        {
            var Types = new List<Type>
            {
                new Type { Name = "Fire" },
                new Type { Name = "Water" },
                new Type { Name = "Grass" },
                new Type { Name = "Ice" },
                new Type { Name = "Ground" },
                new Type { Name = "Rock" },
                new Type { Name = "Electric" },
                new Type { Name = "Ghost" },
                new Type { Name = "Normal" },
            };

            var Pokemons = new List<Pokemon>
            {
                new Pokemon { Name = "Bulbasaur" },
                new Pokemon { Name = "Charmander" },
                new Pokemon { Name = "Flareon" },
                new Pokemon { Name = "Squirtle" },
                new Pokemon { Name = "Lapras" },
                new Pokemon { Name = "Sandshrew" },
                new Pokemon { Name = "Geodude" },
                new Pokemon { Name = "Pikachu" },
                new Pokemon { Name = "Gastly" },
                new Pokemon { Name = "Rattata" },

            };

            new List<Dish>
            {
                new Dish { Name = "Spicy En'Charmad'as", Type = Types.Single(t => t.Name == "Fire"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Charmander"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Flareon Fettuccini", Type = Types.Single(t => t.Name == "Fire"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Flareon"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Bubble Blast Soup", Type = Types.Single(t => t.Name == "Water"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Squirtle"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Vine Whipped Salad", Type = Types.Single(t => t.Name == "Grass"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Bulbasaur"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "IceBeam Icecream", Type = Types.Single(t => t.Name == "Ice"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Lapras"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Earthquake Pound Cake", Type = Types.Single(t => t.Name == "Ground"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Sandshrew"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Stone Edge Martini", Type = Types.Single(t => t.Name == "Rock"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Geodude"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Pika Pizza", Type = Types.Single(t => t.Name == "Electric"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Pikachu"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Cursed Panini", Type = Types.Single(t => t.Name == "Ghost"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Gastly"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Tail Whip Tacos", Type = Types.Single(t => t.Name == "Normal"), Price = 8.99, Pokemon = Pokemons.Single(p => p.Name == "Rattata"), DishImageUrl = "/Assets/images/Pokeball.PNG" },

            }.ForEach(d => context.Dishes.Add(d));
        }
    }
}