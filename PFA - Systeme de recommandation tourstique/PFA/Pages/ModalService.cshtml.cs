using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA.Models;

namespace PFA.Pages
{
    public class ModalServiceModel : PageModel
    {
        private readonly PFAContext _context;

        public ModalServiceModel(PFAContext context)
        {
            _context = context;
        }

        public JsonResult OnGet(int idService, string typeService)
        {
            if (typeService.Equals("activity"))
                return new JsonResult(_context.Activities.Where(h => h.Id == idService).FirstOrDefault());
            if (typeService.Equals("restaurant"))
                return new JsonResult(_context.Restaurants.Where(h => h.Id == idService).FirstOrDefault());
            if (typeService.Equals("hotel"))
                return new JsonResult(_context.Hotels.Where(h => h.Id == idService).FirstOrDefault());

            return new JsonResult(null);
        }
    }
}