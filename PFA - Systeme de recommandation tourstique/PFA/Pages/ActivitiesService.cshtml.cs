using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA.Models;

namespace PFA.Pages
{
    public class ActivitiesServiceModel : PageModel
    {
        private readonly PFAContext _context;

        public ActivitiesServiceModel(PFAContext context)
        {
            _context = context;
        }

        public JsonResult OnGet(string listeActivites)
        {
            var Activities = _context.Activities.Where(a => listeActivites.Contains(a.ImgInteret)).GroupBy(a => a.Nom).Select(a => a.First()).OrderBy(a => a.Id).Take(12).ToList();
            return new JsonResult(Activities);
        }
    }
}