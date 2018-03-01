using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using MenuBuilderEntitesLib;
using Microsoft.AspNetCore.Mvc;
using MenuBuilderContextLib;

namespace MenuBuilderWeb.Pages
{
    public class RecipiesModel : PageModel
    {
        private MenuBuilder db; 

        public RecipiesModel (MenuBuilder injectedContext)
        {
            db = injectedContext;
        }

        public IEnumerable<string> Recipies { get; set; }


        public void OnGet()
        {
            ViewData["Title"] = "Menu builder Web site - Recipies";
            Recipies = db.Recipies.Select(r => r.Name).ToArray();
        
        }

   
        [BindProperty]
        public Recipe Recipe { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Recipies.Add(Recipe);
                db.SaveChanges();
                return RedirectToPage("/Recipies");
            }
            return Page(); 
        }
        //public IEnumerable<string> Recipies { get; set; }
        //public void OnGet()
        //{

        //    ViewData["Title"] = "Menu Build Web SIte - Recipies";

        //    Recipies = new[]

        //    {"Breakfast Meals", "Lunch Meals", "Dinner Meals", "Desserts", ""};


        //}
    }
}