using System;
using System.Collections.Generic;
using System.Text;
using BandTheBirdProj.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BandTheBirdProj.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Admin",
                        NormalizedName = "Admin"
                    },

                    new IdentityRole
                    {
                        Name = "Researcher",
                        NormalizedName = "Researcher"
                    }
                );

        }

        public DbSet<Researcher> Researcher { get; set; }
        public DbSet<BandingData> BandingData { get; set; }
        public DbSet<BiologicalData> BiologicalData { get; set; }
        public DbSet<Environmental> Environmental { get; set; }
        public DbSet<BandTheBirdProj.Models.Species> Species { get; set; }
        public DbSet<BandTheBirdProj.Models.ResearchSite> ResearchSite { get; set; }
    }
}
