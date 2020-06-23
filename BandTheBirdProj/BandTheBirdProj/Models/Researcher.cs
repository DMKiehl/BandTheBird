using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BandTheBirdProj.Models
{
    public class Researcher
    {
        [Key]
        public int ResearchId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Research Site Address")]
        public string ResearchSiteAddress { get; set; }
        [Display(Name = "Site City")]
        public string ResearchSiteCity { get; set; }
        [Display(Name = "Site State")]
        public string ResearchSiteState { get; set; }
        [Display(Name = "Site Zipcode")]
        public string ResearchSiteZip { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
    