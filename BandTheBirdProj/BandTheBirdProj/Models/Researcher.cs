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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ResearchSiteAddress { get; set; }
        public string ResearchSiteCity { get; set; }
        public string ResearchSiteState { get; set; }
        public int ResearchSiteZip { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
    