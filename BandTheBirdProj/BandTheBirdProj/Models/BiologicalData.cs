using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BandTheBirdProj.Models
{
    public class BiologicalData
    {
        [Key]
        public int BioId { get; set; }
        public int Age { get; set; }
        [Display(Name = "How Aged")]
        public string HowAged { get; set; }

        public string Sex { get; set; }
        [Display(Name = "How Sexed")]
        public string HowSexed { get; set; }
        [Display(Name = "CP")]

        public int? CloacalProtuberance{ get; set; }
        [Display(Name = "BP")]
        public int? BroodPatch { get; set; }
        public int? Skull { get; set; }
        public int? Fat { get; set; }
        [Display(Name = "Body Molt")]
        public int? BodyMolt { get; set; }
        [Display(Name = "Flight Feather Molt")]
        public string? FlightFeatherMolt { get; set; }
        [Display(Name = "Flight Feather Wear")]
        public int? FlightFeatherWear { get; set; }
        public double Mass { get; set; }
        [Display(Name = "Wing Chord")]
        public double WingChord { get; set; }
        [Display(Name = "Tail Length")]
        public double TailLength { get; set; }
        [Display(Name = "Exposed Culmen")]
        public double ExposedCulmen { get; set; }
        public double? Tarsus { get; set; }
        public string? Notes { get; set; }
        //public byte? [] Image { get; set; }

        [ForeignKey("BandingData")]
        public int BirdId { get; set; }
        public BandingData BandingData { get; set; }
    }
}
