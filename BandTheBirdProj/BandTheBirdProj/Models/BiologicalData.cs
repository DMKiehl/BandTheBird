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
        public string HowAged { get; set; }

        public string Sex { get; set; }
        public string HowSexed { get; set; }

        public int CloacalProtuberance{ get; set; }
        public int BroodPatch { get; set; }
        public int Skull { get; set; }
        public int Fat { get; set; }
        public int BodyMolt { get; set; }
        public string FlightFeatherMolt { get; set; }
        public int FlightFeatherWear { get; set; }
        public double Mass { get; set; }
        public double WingChord { get; set; }
        public double TailLength { get; set; }
        public double ExposedCulmen { get; set; }
        public double Tarsus { get; set; }
        public string? Notes { get; set; }
        //public byte? [] Image { get; set; }

        [ForeignKey("BandingData")]
        public int BirdId { get; set; }
        public BandingData BandingData { get; set; }
    }
}
