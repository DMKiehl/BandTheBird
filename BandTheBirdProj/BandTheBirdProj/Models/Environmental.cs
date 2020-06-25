using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace BandTheBirdProj.Models
{
    public class Environmental
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime? ResearchDate { get; set; }

        [Display(Name = "Opening Temperature")]
        public double? OpenTemp { get; set; }
        [Display(Name = "Closing Temperature")]
        public double? CloseTemp { get; set; }
        [Display(Name = "Cloud Cover(Percentage)")]
        public string CloudCover { get; set; }
        public string Precipitation { get; set; }
        [Display(Name = "Open Time")]
        public string OpenTime { get; set; }
        [Display(Name = "Close Time")]
        public string? CloseTime { get; set; }

        [ForeignKey("ResearchSite")]
        public int SiteId { get; set; }
        [Display(Name = "Research Site Name")]
        public string SiteName { get; set; }
        public ResearchSite ResearchSite { get; set; }
    }
}
