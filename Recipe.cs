using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; } // Update to a public get property

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public int CalculateTotalCalories()
        {
            return Ingredients.Sum(i => i.Calories);
        }


    }
}

