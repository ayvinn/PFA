using System;
using System.Collections.Generic;

namespace PFA.Models
{
    public partial class LocationVacance
    {
        public int Id { get; set; }
        public string Lv { get; set; }
        public int? NbrChambres { get; set; }
        public int? SallesDeBains { get; set; }
        public int? Couchage { get; set; }
        public int? Prix { get; set; }
        public string Img { get; set; }
        public string LienRes { get; set; }
        public string LvServices { get; set; }
    }
}
