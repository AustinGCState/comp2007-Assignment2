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
            var type = new List<Type>
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

            var pokemon = new List<Pokemon>
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
                new Dish { Name = "Spicy En'Charmad'as", Types = type.Single(t => t.Name == "Fire"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Charmander"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Flareon Fettuccini", Types = type.Single(t => t.Name == "Fire"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Flareon"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Bubble Blast Soup", Types = type.Single(t => t.Name == "Water"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Squirtle"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Vine Whipped Salad", Types = type.Single(t => t.Name == "Grass"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Bulbasaur"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "IceBeam Icecream", Types = type.Single(t => t.Name == "Ice"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Lapras"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Earthquake Pound Cake", Types = type.Single(t => t.Name == "Ground"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Sandshrew"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Stone Edge Martini", Types = type.Single(t => t.Name == "Rock"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Geodude"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Pika Pizza", Types = type.Single(t => t.Name == "Electic"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Pikachu"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Cursed Panini", Types = type.Single(t => t.Name == "Ghost"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Ghastly"), DishImageUrl = "/Assets/images/Pokeball.PNG" },
                new Dish { Name = "Tail Whip Tacos", Types = type.Single(t => t.Name == "Normal"), Price = 8.99, Pokemon = pokemon.Single(p => p.Name == "Rattata"), DishImageUrl = "/Assets/images/Pokeball.PNG" },

            }.ForEach(d => context.Dishs.Add(d));
        }
    }
}