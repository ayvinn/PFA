using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA.Models;

namespace PFA.Pages
{
    public class HotelsServiceModel : PageModel
    {
        private readonly PFAContext _context;

        public HotelsServiceModel(PFAContext context)
        {
            _context = context;
        }
        public JsonResult OnGet(string budgetHotel)
        {
            var Hotels = _context.Hotels.Where(h => double.Parse(h.Prix.ToString()) <= double.Parse(budgetHotel)).OrderBy(h => h.Id).Take(12).ToList();
            return new JsonResult(Hotels);
        }
    }
}