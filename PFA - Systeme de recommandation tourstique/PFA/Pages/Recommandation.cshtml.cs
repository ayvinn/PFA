using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PFA.Models;

namespace PFA.Pages
{
    public class RecommandationModel : PageModel
    {
        private readonly PFAContext _context;

        public RecommandationModel(PFAContext context)
        {
            _context = context;
        }

        public List<string> Images;
        public string Flag { get; set; }
        public List<Activities> Activities { get; set; }
        public List<Hotels> Hotels { get; set; }
        public List<Restaurants> Restaurants { get; set; }
        public List<LocationVacance> LocationVacances { get; set; }
        public IActionResult OnPost(string ville, string localisation, DateTime dtDepart, int nbJoursValue, int nbPersonnesValue, int budgetStartValue, int budgetEndValue, string listeActivites)
        {
            ViewData["listeActivites"] = listeActivites;
            ViewData["minBudget"] = budgetStartValue;
            ViewData["maxBudget"] = budgetEndValue;
            ViewData["budgetMoyen"] = ((budgetEndValue - budgetStartValue) / 2) + budgetStartValue;
            Flag = Url.Content(string.Format("~/images/flag/ma.png"));

            Images = new List<string>();
            for (int i = 1; i < 11; i++)
            {
                Images.Add(Url.Content(string.Format("~/images/villes/" + ville.ToLower() + "/" + i.ToString() + ".jpg")));
            }

            var budgetMin = (budgetStartValue * 1.0) / nbJoursValue;
            var budgetMax = (budgetEndValue * 1.0) / nbJoursValue;

            var budgetHotel = (budgetMax * 50) / 100;
            ViewData["budgetHotel"] = budgetHotel;
            var budgetFoods = (budgetMax * 25) / 100;
            ViewData["budgetFoods"] = budgetFoods;
            var budgetActivities = (budgetMax * 25) / 100;


            Hotels = _context.Hotels.Where(h => (double)h.Prix / 10 <= budgetHotel).OrderBy(h => h.Id).Take(12).ToList();
            Activities = _context.Activities.Where(a => listeActivites.Contains(a.ImgInteret)).GroupBy(a => a.Nom).Select(a => a.First()).OrderBy(a=>a.Id).Take(12).ToList();
            Restaurants = _context.Restaurants.Take(12).ToList();
            LocationVacances = _context.LocationVacance.Take(12).ToList();

            ViewData["locationRestaurants"] = Restaurants.Where(r => r.Adresse != null).Select(r => r.Adresse).ToArray();
            ViewData["locationHotels"] = Hotels.Where(r => r.Adresse != null).Select(r => r.Adresse).ToArray();
            ViewData["locationActivities"] = Activities.Where(r => r.Adresse != null).Select(r => r.Adresse).ToArray();


            ViewData["aPartirH"] = 0;
            ViewData["aPartirR"] = 0;
            ViewData["aPartirA"] = 12;
            return Page();
        }
    }
}