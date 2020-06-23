using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandTheBirdProj.Models
{
    public class BandSize
    {
        [Key]
        public int Id { get; set; }
        public string Size { get; set; }
    }
}
