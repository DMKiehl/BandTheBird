using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BandTheBirdProj.Models
{
    public class BiologicalViewModel
    {

        public Species Species { get; set; }
        
        public BiologicalData BiologicalData { get; set; }

        [Display(Name = "Please check box to verify")]
        public bool VerifyData { get; set; }
    
    }
}
