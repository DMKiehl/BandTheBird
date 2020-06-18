using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandTheBirdProj.Models
{
    public class ResearchSite
    {
        [Key]
        public int SiteId { get; set; }
        [Display(Name = "Site Name")]
        public string SiteName { get; set; }
        [Display(Name = "Street Address")]
        public string SiteStreetAddress { get; set; }
        [Display(Name = "City")]
        public string SiteCity { get; set; }
        [Display(Name = "State")]
        public string SiteState { get; set; }
        [Display(Name = "ZipCode")]
        public string SiteZip { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }


    }
}
