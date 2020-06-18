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
        public string SiteName { get; set; }
        public string SiteStreetAddress { get; set; }
        public string SiteCity { get; set; }
        public string SiteState { get; set; }
        public string SiteZip { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }


    }
}
