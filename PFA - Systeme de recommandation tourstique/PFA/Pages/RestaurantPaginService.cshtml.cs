using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA.Models;

namespace PFA.Pages
{
  
    public class RestaurantPaginServiceModel : PageModel
    {
        private readonly PFAContext _context;

        public RestaurantPaginServiceModel(PFAContext context)
        {
            _context = context;
        }
        public JsonResult OnGet(string budgetFoods,int aPartirR)
        {
            var Restaurants = _context.Restaurants.Where(f => f.Classement <= double.Parse(budgetFoods)).OrderBy(r => r.Id).ToList();
            Restaurants = Restaurants.Where(f => f.Id > Restaurants[aPartirR - 1].Id).OrderBy(f => f.Id).Take(4).ToList();
          
            return new JsonResult(Restaurants);
        }
    }
}