using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Identity;

namespace BandTheBirdProj.Models
{
    public class Images
    {
        [Key]
        public int Id { get; set; }
        public string AlphaCode { get; set; }
        public int BandNumber { get; set; }

        public string BirdImage { get; set; }


        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
