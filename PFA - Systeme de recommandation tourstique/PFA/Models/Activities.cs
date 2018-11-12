using System;
using System.Collections.Generic;

namespace PFA.Models
{
    public partial class Activities
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Img { get; set; }
        public string PlusInfo { get; set; }
        public int? ClassementIntype { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Overture { get; set; }
        public string Fermeture { get; set; }
        public string ActiviteTypes { get; set; }
        public double? Avis { get; set; }
        public string Descriptions { get; set; }
        public string ImgInteret { get; set; }
    }
}
