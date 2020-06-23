using System;
using System.Collections.Generic;
using System.Text;
using BandTheBirdProj.Models;
using DocumentFormat.OpenXml.Wordprocessing;
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
            builder.Entity<CP>()
                .HasData(
                new CP
                {
                    Id = 1,
                    Name = "Small",
                });
            builder.Entity<CP>()
             .HasData(
             new CP
             {
                 Id = 2,
                 Name = "Medium",
             });
            builder.Entity<CP>()
            .HasData(
            new CP
            {
                Id = 3,
                Name = "Large",
            });
            builder.Entity<CP>()
            .HasData(
            new CP
            {
                Id = 4,
                Name = "None",
            });
            builder.Entity<BP>()
              .HasData(
              new BP
              {
                  Id = 1,
                  Code = 0,
                  Name = "None",
              });
            builder.Entity<BP>()
              .HasData(
              new BP
              {
                  Id = 2,
                  Code = 1,
                  Name = "Smooth",
              });
            builder.Entity<BP>()
              .HasData(
              new BP
              {
                  Id = 3,
                  Code = 2,
                  Name = "Vascular",
              });
            builder.Entity<BP>()
              .HasData(
              new BP
              {
                  Id = 4,
                  Code = 3,
                  Name = "Heavy",
              });
            builder.Entity<BP>()
              .HasData(
              new BP
              {
                  Id = 5,
                  Code = 4,
                  Name = "Wrinkled",
              });
            builder.Entity<BP>()
              .HasData(
              new BP
              {
                  Id = 6,
                  Code = 5,
                  Name = "Molting",
              });
            builder.Entity<Fat>()
             .HasData(
             new Fat
             {
                 Id = 1,
                 Code = 0,
                 Name = "None",
             });
            builder.Entity<Fat>()
                .HasData(
                new Fat
                {
                    Id = 2,
                    Code = 1,
                    Name = "Trace",
                });
            builder.Entity<Fat>()
                .HasData(
                new Fat
                {
                    Id = 3,
                    Code = 2,
                    Name = "Light",
                });
            builder.Entity<Fat>()
                .HasData(
                new Fat
                {
                    Id = 4,
                    Code = 3,
                    Name = "Half",
                });
            builder.Entity<Fat>()
                .HasData(
                new Fat
                {
                    Id = 5,
                    Code = 4,
                    Name = "Filled",
                });
            builder.Entity<Fat>()
                 .HasData(
                 new Fat
                 {
                     Id = 6,
                     Code = 5,
                     Name = "Bulging",
                 });
            builder.Entity<Fat>()
                .HasData(
                new Fat
                {
                    Id = 7,
                    Code = 6,
                    Name = "Gr. Bulging",
                });
            builder.Entity<Fat>()
                .HasData(
                new Fat
                {
                    Id = 8,
                    Code = 7,
                    Name = "Very Excessive",
                });
            builder.Entity<BodyMolt>()
              .HasData(
              new BodyMolt
              {
                  Id = 1,
                  Code = 0,
                  Name = "None",
              });
            builder.Entity<BodyMolt>()
              .HasData(
              new BodyMolt
              {
                  Id = 2,
                  Code = 1,
                  Name = "Trace",
              });
            builder.Entity<BodyMolt>()
                .HasData(
                new BodyMolt
                {
                    Id = 3,
                    Code = 2,
                    Name = "Light",
                });
            builder.Entity<BodyMolt>()
               .HasData(
               new BodyMolt
               {
                   Id = 4,
                   Code = 3,
                   Name = "Medium",
               });
            builder.Entity<BodyMolt>()
               .HasData(
               new BodyMolt
               {
                   Id = 5,
                   Code = 4,
                   Name = "Heavy",
               });
            builder.Entity<FlightMolt>()
             .HasData(
             new FlightMolt
             {
                 Id = 1,
                 Code = "N",
                 Name = "None",
             });
            builder.Entity<FlightMolt>()
                .HasData(
                new FlightMolt
                {
                    Id = 2,
                    Code = "A",
                    Name = "Adventitious",
                });
            builder.Entity<FlightMolt>()
              .HasData(
              new FlightMolt
              {
                  Id = 3,
                  Code = "S",
                  Name = "Symmetric",
              });
            builder.Entity<FlightMolt>()
              .HasData(
              new FlightMolt
              {
                  Id = 4,
                  Code = "J",
                  Name = "Juvenile Growth",
              });
            builder.Entity<FlightWear>()
                .HasData(
                new FlightWear
                {
                  Id = 1,
                  Code = 0,
                  Name = "None",
                 });
            builder.Entity<FlightWear>()
                .HasData(
                new FlightWear
                {
                    Id = 2,
                    Code = 1,
                    Name = "Slight",
                });
            builder.Entity<FlightWear>()
                .HasData(
                new FlightWear
                {
                    Id = 3,
                    Code = 2,
                    Name = "Light",
                });
            builder.Entity<FlightWear>()
                .HasData(
                new FlightWear
                {
                    Id = 4,
                    Code = 3,
                    Name = "Moderate",
                });
            builder.Entity<FlightWear>()
                .HasData(
                new FlightWear
                {
                    Id = 5,
                    Code = 4,
                    Name = "Heavy",
                });
            builder.Entity<FlightWear>()
                .HasData(
                new FlightWear
                {
                    Id = 6,
                    Code = 5,
                    Name = "Excessive",
                });
            builder.Entity<BandSize>()
               .HasData(
               new BandSize
               {
                   Id = 1,
                   Size = "0A",
                   
               });
            builder.Entity<BandSize>()
               .HasData(
               new BandSize
               {
                   Id = 2,
                   Size = "0",
               });
            builder.Entity<BandSize>()
                .HasData(
                new BandSize
                {
                    Id = 3,
                    Size = "1",
                });
            builder.Entity<BandSize>()
                .HasData(
                new BandSize
                {
                    Id = 4,
                    Size = "1B",
                });
            builder.Entity<BandSize>()
             .HasData(
             new BandSize
             {
                 Id = 5,
                 Size = "1A",
             });
            builder.Entity<BandSize>()
             .HasData(
             new BandSize
             {
                 Id = 6,
                 Size = "2",
             });
            builder.Entity<BandSize>()
             .HasData(
             new BandSize
             {
                 Id = 7,
                 Size = "3",
             });
            builder.Entity<BandSize>()
                .HasData(
                new BandSize
                {
                    Id = 8,
                    Size = "R"
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
        public DbSet<CP> CP { get; set; }
        public DbSet<BP> BP { get; set; }
        public DbSet<Fat> Fat { get; set; }
        public DbSet<BodyMolt> BodyMolt { get; set; }
        public DbSet<FlightMolt> FlightMolt { get; set; }
        public DbSet<FlightWear> FlightWear { get; set; }
        public DbSet<BandSize> BandSize { get; set; }
    }
}
