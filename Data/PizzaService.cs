using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Data
{
    public class PizzaService
    {
        public async Task <List<PizzaData>>  GetPizzasAsync() 
        {
            var pizzaSpecial = new List<PizzaData>()
        {
            new PizzaData{PizzaId = 1, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false},
            new PizzaData{PizzaId = 2, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false},
            new PizzaData{PizzaId = 3, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false},
            new PizzaData{PizzaId = 4, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false},
            new PizzaData{PizzaId = 5, Name = "The Baconatorizor", Price =  11.99M, Description = "It has EVERY kind of bacon", Vegan = false, Vegetarian = false}
        };
            return pizzaSpecial;
        }
    }
}