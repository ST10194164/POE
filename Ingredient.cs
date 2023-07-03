using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class Ingredient
    {

        public string Name { get; set; }
        public int Calories { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string Quantity { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name, int calories, string unitOfMeasurement, string quantity, string foodGroup)
        {
            Name = name;
            Calories = calories;
            UnitOfMeasurement = unitOfMeasurement;
            Quantity = quantity;
            FoodGroup = foodGroup;
        }

        public string IngredientInfo => $"{Name} - {Quantity} {UnitOfMeasurement} - {FoodGroup}";
    }

}
    