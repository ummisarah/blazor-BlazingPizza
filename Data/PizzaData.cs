using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Data
{
    public class PizzaData
    {
         public int PizzaId { get; set; }
    
        public string Name { get; set; }
    
        public string Description { get; set; }
    
        public decimal Price { get; set; }
    
        public bool Vegetarian { get; set; }
    
        public bool Vegan { get; set; }
    }
}