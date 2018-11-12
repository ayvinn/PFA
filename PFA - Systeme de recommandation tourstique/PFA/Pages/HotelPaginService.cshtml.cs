using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA.Models;

namespace PFA.Pages
{
    public class HotelPaginServiceModel : PageModel
    {
        private readonly PFAContext _context;

        public HotelPaginServiceModel(PFAContext context)
        {
            _context = context;
        }
        public JsonResult OnGet(string budgetHotel,int aPartirH)
        {
            var Hotels = _context.Hotels.Where(h => double.Parse(h.Prix.ToString()) <= double.Parse(budgetHotel)).OrderBy(h => h.Id).ToList();
            Hotels = Hotels.Where(h => h.Id > Hotels[aPartirH - 1].Id).OrderBy(h => h.Id).Take(4).ToList();
            return new JsonResult(Hotels);
        }
    }
}