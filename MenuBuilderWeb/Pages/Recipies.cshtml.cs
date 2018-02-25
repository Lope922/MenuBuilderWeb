using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MenuBuilderWeb.Pages
{
    public class RecipiesModel : PageModel
    {

        public IEnumerable<string> Recipies { get; set; }
        public void OnGet()
        {

            ViewData["Title"] = "Menu Build Web SIte - Recipies";

            Recipies = new[]

            {"Breakfast Meals", "Lunch Meals", "Dinner Meals", "Desserts", ""};


        }
    }
}