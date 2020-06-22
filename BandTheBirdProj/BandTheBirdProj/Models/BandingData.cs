using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BandTheBirdProj.Models
{
    public class BandingData
    {
        [Key]
        public int BirdId { get; set; }
        public double BandNumber { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? CaptureDate { get; set; }
        public string BanderIntials { get; set; }
        public string CaptureTime { get; set; }
        public int NetNumber { get; set; }
        public string BandType { get; set; }
        public string BandSize { get; set; }
        public string AlphaCode { get; set; }
        public string SpeciesName { get; set; }     

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("ResearchSite")]
        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public ResearchSite ResearchSite { get; set; }

        


    }
}
