using System;
using System.Collections.Generic;

namespace PFA.Models
{
    public partial class Hotels
    {
        public int Id { get; set; }
        public string Hotel { get; set; }
        public int? Prix { get; set; }
        public string Img { get; set; }
        public string LienRes { get; set; }
        public string Adresse { get; set; }
        public int? Classement { get; set; }
        public string Tel { get; set; }
        public double? Avis { get; set; }
        public int? DescNbrEtoils { get; set; }
        public string DescMeilleursServices { get; set; }
        public string DescEquipementschambre { get; set; }
        public string DescAFaire { get; set; }
        public string DescFourchetteDePrix { get; set; }
    }
}
