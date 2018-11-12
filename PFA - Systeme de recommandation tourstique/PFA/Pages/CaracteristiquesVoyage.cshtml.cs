using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA.Models;

namespace PFA.Pages
{


    public class CaracteristiquesVoyageModel : PageModel
    {
        [BindProperty]
        public string ville { get; set; }
        public List<Interets> Interets;
        public IActionResult OnPost()
        {
            Interets = Services.interets;
            return Page();
        }
    }
}