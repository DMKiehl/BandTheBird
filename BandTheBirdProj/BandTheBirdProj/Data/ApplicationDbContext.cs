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

            builder.Entity<BandType>()
                .HasData(
                new BandType
                {
                    Id = 1,
                    Code = "N",
                    Name = "New Band",
                });

            builder.Entity<BandType>()
               .HasData(
               new BandType
               {
                   Id = 2,
                   Code = "D",
                   Name = "Band Destroyed",
               });

            builder.Entity<BandType>()
               .HasData(
               new BandType
               {
                   Id = 3,
                   Code = "L",
                   Name = "Band Lost",
               });

            builder.Entity<BandType>()
               .HasData(
               new BandType
               {
                   Id = 4,
                   Code = "C",
                   Name = "Band Changed",
               });

            builder.Entity<BandType>()
               .HasData(
               new BandType
               {
                   Id = 5,
                   Code = "A",
                   Name = "Band Added",
               });

            builder.Entity<BandType>()
               .HasData(
               new BandType
               {
                   Id = 6,
                   Code = "R",
                   Name = "Recapture",
               });

            builder.Entity<Sex>()
              .HasData(
              new Sex
              {
                  Id = 1,
                  Code = "M",
                  Name = "Male",
              });

            builder.Entity<Sex>()
              .HasData(
              new Sex
              {
                  Id = 2,
                  Code = "F",
                  Name = "Female",
              });
            builder.Entity<Sex>()
              .HasData(
              new Sex
              {
                  Id = 3,
                  Code = "U",
                  Name = "Undetermined",
              });
            builder.Entity<Sex>()
              .HasData(
              new Sex
              {
                  Id = 4,
                  Code = "X",
                  Name = "Not Attempted",
              });

            builder.Entity<Age>()
              .HasData(
              new Age
              {
                  Id = 1,                
                  Name = "After Hatch Year",
              });

            builder.Entity<Age>()
             .HasData(
             new Age
             {
                 Id = 2,
                 Name = "Hatch Year",
             });
            builder.Entity<Age>()
             .HasData(
             new Age
             {
                 Id = 4,
                 Name = "Local",
             });
            builder.Entity<Age>()
             .HasData(
             new Age
             {
                 Id = 5,
                 Name = "Second Year",
             });
            builder.Entity<Age>()
              .HasData(
              new Age
              {
                  Id = 6,                
                  Name = "After Second Year",
              });
            builder.Entity<Age>()
             .HasData(
             new Age
             {
                 Id = 7,
                 Name = "Third Year",
             });
            builder.Entity<Age>()
             .HasData(
             new Age
             {
                 Id = 8,
                 Name = "After Third Year",
             });
            builder.Entity<Age>()
             .HasData(
             new Age
             {
                 Id = 9,
                 Name = "Not Attempted",
             });
            builder.Entity<Age>()
             .HasData(
             new Age
             {
                 Id = 3,
                 Name = "Indeterminable",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 1,
                 Code = "S",
                 Name = "Skull",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 2,
                 Code = "C",
                 Name = "Cloacal Prot.",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 3,
                 Code = "B",
                 Name = "Brood Patch",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 4,
                 Code = "J",
                 Name = "Juvenile Body Plumage",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 5,
                 Code = "L",
                 Name = "Molt Limit",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 6,
                 Code = "P",
                 Name = "Plumage",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 7,
                 Code = "M",
                 Name = "Molt",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 8,
                 Code = "F",
                 Name = "Feather Wear",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 9,
                 Code = "I",
                 Name = "Mouth/Bill",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 10,
                 Code = "E",
                 Name = "Eye Color",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 11,
                 Code = "W",
                 Name = "Wing Length",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 12,
                 Code = "T",
                 Name = "Tail Length",
             });
            builder.Entity<HowAgeSex>()
             .HasData(
             new HowAgeSex
             {
                 Id = 13,
                 Code = "O",
                 Name = "Other(Note)",
             });
            builder.Entity<Skull>()
                .HasData(
                new Skull
                {
                    Id = 10,
                    Name = "None",
                });
            builder.Entity<Skull>()
              .HasData(
              new Skull
              {
                  Id = 1,
                  Name = "Trace",
              });
            builder.Entity<Skull>()
             .HasData(
             new Skull
             {
                 Id = 2,
                 Name = "< 1/3",
             });
            builder.Entity<Skull>()
             .HasData(
             new Skull
             {
                 Id = 3,
                 Name = "Half",
             });
            builder.Entity<Skull>()
             .HasData(
             new Skull
             {
                 Id = 4,
                 Name = "> 2/3",
             });
            builder.Entity<Skull>()
                .HasData(
                new Skull
                {
                    Id = 5,
                    Name = "Almost Complete",
                });
            builder.Entity<Skull>()
             .HasData(
             new Skull
             {
                 Id = 6,
                 Name = "Fully Complete",
             });
            builder.Entity<Skull>()
             .HasData(
             new Skull
             {
                 Id = 8,
                 Name = "Invisible",
             });
            builder.Entity<Skull>()
             .HasData(
             new Skull
             {
                 Id = 9,
                 Name = "Did not Attempt",
             });


        }

        public DbSet<Researcher> Researcher { get; set; }
        public DbSet<BandingData> BandingData { get; set; }
        public DbSet<BiologicalData> BiologicalData { get; set; }
        public DbSet<Environmental> Environmental { get; set; }
        public DbSet<BandTheBirdProj.Models.Species> Species { get; set; }
        public DbSet<BandTheBirdProj.Models.ResearchSite> ResearchSite { get; set; }
        public DbSet<BandType> BandType { get; set; }
        public DbSet<Sex> Sex { get; set; }
        public DbSet<Age> Age { get; set; }
        public DbSet<HowAgeSex> HowAgeSex { get; set; }
        public DbSet<Skull> Skull { get; set; }
    }
}
