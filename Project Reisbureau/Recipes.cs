using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Reisbureau
{
    public class Recipes
    {
        public class Recipe
        {
            public string Name { get; set; }
            public string Ingredients { get; set; }
            public string Instructions { get; set; }
            public bool Vegetarian { get; set; }
            public bool Vegan { get; set; }
            public bool GlutenFree { get; set; }
        }
    }
}
