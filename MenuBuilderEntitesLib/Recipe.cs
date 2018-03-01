using System;

namespace MenuBuilderEntitesLib
{
    public class Recipe
    {
        public Guid RecipeId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Instructions { get; set; }
        public string Tips { get; set; }

        // both in minutes - may need to change to datetime or just time 
        public int CookTime { get; set; }
        public int PrepTime { get; set; }

        public string Ingredients { get; set; }
        public string Source { get; set; }
        public int PageNum { get; set; }
        public string MealType { get; set; }
        public string DishType { get; set; }

    }
}
