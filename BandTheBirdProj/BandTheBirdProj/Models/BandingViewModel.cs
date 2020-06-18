using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandTheBirdProj.Models
{
    public class BandingViewModel
    {
        public Species Species { get; set; }
        public BandingData BandingData { get; set; }
        public BiologicalData BiologicalData { get; set; }
    }
}
