using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class Menu
    {
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public decimal MealPrice { get; set; }


        public Menu()
        {

        }
        public Menu(string mealName, int mealNumber, string mealDescription, string mealIngredients, decimal mealPrice)
        {
            MealName = mealName;
            MealNumber = mealNumber;
            MealDescription = mealDescription;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;


        }

    }
}
