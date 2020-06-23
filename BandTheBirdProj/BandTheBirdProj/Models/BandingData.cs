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
        [Display(Name = "Band Number")]
        public double BandNumber { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? CaptureDate { get; set; }
        [Display(Name = "Bander Intials")]
        public string BanderIntials { get; set; }
        [Display(Name = "Capture Time")]
        public string CaptureTime { get; set; }
        [Display(Name = "Net Number")]
        public int NetNumber { get; set; }
        [Display(Name = "Band Type")]
        public string BandType { get; set; }
        [Display(Name = "Band Size")]
        public string BandSize { get; set; }
        [Display(Name = "Alpha Code")]
        public string AlphaCode { get; set; }
        [Display(Name = "Species Name")]
        public string SpeciesName { get; set; }     

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("ResearchSite")]
        public int SiteId { get; set; }
        [Display(Name = "Site Name")]
        public string SiteName { get; set; }
        public ResearchSite ResearchSite { get; set; }

        


    }
}
