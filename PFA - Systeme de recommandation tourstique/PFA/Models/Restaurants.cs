using System;
using System.Collections.Generic;

namespace PFA.Models
{
    public partial class Restaurants
    {
        public int Id { get; set; }
        public string ResEtab { get; set; }
        public string InfoPlus { get; set; }
        public string Img { get; set; }
        public int? Classement { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Repas { get; set; }
        public string ServicesRestau { get; set; }
        public string Conselle { get; set; }
        public string Desccriptions { get; set; }
    }
}
