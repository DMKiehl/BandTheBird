using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BandTheBirdProj.Models
{
    public class Skull
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
