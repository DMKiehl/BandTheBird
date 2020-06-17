using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        [Display(Name = "Opening Temperature")]
        public double? OpenTemp { get; set; }
        [Display(Name = "Closing Temperature")]
        public double? CloseTemp { get; set; }
        [Display(Name = "Cloud Cover")]
        public string CloudCover { get; set; }
        public string Precipitation { get; set; }
        [Display(Name = "Open Time")]
        public string OpenTime { get; set; }
        [Display(Name = "Close Time")]
        public string? CloseTime { get; set; }
    }
}
