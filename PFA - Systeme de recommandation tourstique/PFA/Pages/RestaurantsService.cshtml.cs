using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA.Models;

namespace PFA.Pages
{
    public class RestaurantsServiceModel : PageModel
    {
        private readonly PFAContext _context;

        public RestaurantsServiceModel(PFAContext context)
        {
            _context = context;
        }
        public JsonResult OnGet(string budgetFoods)
        {
            var Restaurants = _context.Restaurants.Where(f => f.Classement <= double.Parse(budgetFoods)).OrderBy(r => r.Id).Take(12).ToList();
            return new JsonResult(Restaurants);
        }
    }
}