using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA.Models;

namespace PFA.Pages
{
    public class paginationServiceModel : PageModel
    {
        private readonly PFAContext _context;

        public paginationServiceModel(PFAContext context)
        {
            _context = context;
        }

        public JsonResult OnGet(int aPartir, string typeService)
        {
            if (typeService.Equals("activity"))
            {
                return new JsonResult(_context.Activities.Where(a => a.Id > aPartir).Take(4).ToList());
            }
            else if (typeService.Equals("restaurant"))
            {
                return new JsonResult(_context.Restaurants.Where(a => a.Id > aPartir).Take(4).ToList());
            }
            else if (typeService.Equals("hotel"))
            {
                return new JsonResult(_context.Hotels.Where(a => a.Id > aPartir).Take(4).ToList());
            }



            /*
            var Activities = _context.Activities.Where(a => listeActivites.Contains(a.ImgInteret)).GroupBy(a => a.Nom).Select(a => a.First()).OrderBy(a => a.Id).ToList();
            Activities = Activities.Where(a => a.Id > Activities[aPartirA - 1].Id).OrderBy(a => a.Id).Take(4).ToList();
            return new JsonResult(Activities);
            */
             return new JsonResult(null);
        }
    }
}
 