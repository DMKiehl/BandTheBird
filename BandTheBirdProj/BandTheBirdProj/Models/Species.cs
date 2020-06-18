using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandTheBirdProj.Models
{

    public class Species
    {
        public int speciesId { get; set; }
        [Display(Name = "Alpha Code")]
        public string alphaCode { get; set; }
        [Display(Name = "Species Name")]
        public string speciesName { get; set; }
        [Display(Name = "Band Size")]
        public string bandSize { get; set; }
        [Display(Name = "Minimum Wing")]
        public int minWing { get; set; }
        [Display(Name = "Maximum Wing")]
        public int maxWing { get; set; }
        [Display(Name = "Minimum Tail")]
        public int minTail { get; set; }
        [Display(Name = "Maximum Wing")]
        public int maxTail { get; set; }
        [Display(Name = "Minumum Exposed Culmen")]
        public float minCulmen { get; set; }
        [Display(Name = "Maxiumum Exposed Culmen")]
        public float maxCulmen { get; set; }
    }

}
