using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BandTheBirdProj.Models
{
    public class ImageViewModel
    {
        public string AlphaCode { get; set; }
        public int BandNumber { get; set; }
        public IFormFile BirdImage { get; set; }

    }
}
