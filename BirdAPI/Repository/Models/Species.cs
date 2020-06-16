using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Species
    {
        [Key]
        public int SpeciesId { get; set; }
        public string AlphaCode { get; set; }
        public string BandSize { get; set; }
        public double MinWing { get; set; }
        public double MaxWing { get; set; }
        public double MinTail { get; set; }
        public double MaxTail { get; set; }
        public double MinCulmen { get; set; }
        public double MaxCulmen { get; set; }
        public double MinBillToTip { get; set; }
        public double MaxBillToTip { get; set; }

    }
}
