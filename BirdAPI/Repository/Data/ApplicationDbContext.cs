using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Species> Species { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Species>()
                    .HasData(
                    new Species
                    {
                        SpeciesId = 1,
                        AlphaCode = "RWBL",
                        SpeciesName = "Red-winged Blackbird",
                        BandSize = "F-1A/M-2",
                        MinWing = 88,
                        MaxWing = 135,
                        MinTail = 64,
                        MaxTail = 105,
                        MinCulmen = 15.3,
                        MaxCulmen = 16.5,

                    });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 2,
                       AlphaCode = "EABL",
                       SpeciesName = "Eastern Bluebird",
                       BandSize = "1B-1",
                       MinWing = 91,
                       MaxWing = 109,
                       MinTail = 57,
                       MaxTail = 70,
                       MinCulmen = 7,
                       MaxCulmen = 11,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 3,
                       AlphaCode = "GRCA",
                       SpeciesName = "Gray Catbird",
                       BandSize = "1A",
                       MinWing = 81,
                       MaxWing = 99,
                       MinTail = 81,
                       MaxTail = 104,
                       MinCulmen = 13.3,
                       MaxCulmen = 17.8,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 4,
                       AlphaCode = "BCCH",
                       SpeciesName = "Black-capped Chickadee",
                       BandSize = "0",
                       MinWing = 57,
                       MaxWing = 73,
                       MinTail = 53,
                       MaxTail = 72,
                       MinCulmen = 7.6,
                       MaxCulmen = 10.5,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 5,
                       AlphaCode = "BHCO",
                       SpeciesName = "Brown-headed Cowbird",
                       BandSize = "F-1B/M-1A",
                       MinWing = 85,
                       MaxWing = 104,
                       MinTail = 57,
                       MaxTail = 79,
                       MinCulmen = 12.7,
                       MaxCulmen = 16.0,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 6,
                       AlphaCode = "BBCU",
                       SpeciesName = "Black-billed Cuckoo",
                       BandSize = "2",
                       MinWing = 137,
                       MaxWing = 147,
                       MinTail = 146,
                       MaxTail = 167,
                       MinCulmen = 20.2,
                       MaxCulmen = 23.9,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 7,
                       AlphaCode = "BRCR",
                       SpeciesName = "Brown Creeper",
                       BandSize = "0A-0",
                       MinWing = 57,
                       MaxWing = 69,
                       MinTail = 53,
                       MaxTail = 69,
                       MinCulmen = 16.9,
                       MaxCulmen = 22.1,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 8,
                       AlphaCode = "MYWA",
                       SpeciesName = "Myrtle Warbler",
                       BandSize = "0",
                       MinWing = 65,
                       MaxWing = 78,
                       MinTail = 53,
                       MaxTail = 60,
                       MinCulmen = 8.4,
                       MaxCulmen = 10.3,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 9,
                       AlphaCode = "MODO",
                       SpeciesName = "Mourning Dove",
                       BandSize = "3A-3B",
                       MinWing = 131,
                       MaxWing = 159,
                       MinTail = 114,
                       MaxTail = 163,
                       MinCulmen = 18,
                       MaxCulmen = 22.5,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 10,
                       AlphaCode = "HOFI",
                       SpeciesName = "House Finch",
                       BandSize = "1B-1",
                       MinWing = 70,
                       MaxWing = 83,
                       MinTail = 51,
                       MaxTail = 66,
                       MinCulmen = 9.5,
                       MaxCulmen = 12,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 11,
                       AlphaCode = "PUFI",
                       SpeciesName = "Purple Finch",
                       BandSize = "1-1B",
                       MinWing = 71,
                       MaxWing = 87,
                       MinTail = 53,
                       MaxTail = 87,
                       MinCulmen = 9.5,
                       MaxCulmen =12,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 12,
                       AlphaCode = "CSWA",
                       SpeciesName = "Chestnut-sided Warbler",
                       BandSize = "0A-0",
                       MinWing = 56,
                       MaxWing = 68,
                       MinTail = 42,
                       MaxTail = 52,
                       MinCulmen = 9.4,
                       MaxCulmen = 9.9,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 13,
                       AlphaCode = "BGGN",
                       SpeciesName = "Blue-Gray Gnatcatcher",
                       BandSize = "0A",
                       MinWing = 46,
                       MaxWing = 56,
                       MinTail = 47,
                       MaxTail = 55,
                       MinCulmen = 8.8,
                       MaxCulmen = 11.2,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 14,
                       AlphaCode = "AMGO",
                       SpeciesName = "American Goldfinch",
                       BandSize = "0",
                       MinWing = 63,
                       MaxWing = 79,
                       MinTail = 39,
                       MaxTail = 52,
                       MinCulmen = 8.9,
                       MaxCulmen = 10.2,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 15,
                       AlphaCode = "COGR",
                       SpeciesName = "Common Grackle",
                       BandSize = "3-3B",
                       MinWing = 115,
                       MaxWing = 150,
                       MinTail = 97,
                       MaxTail = 148,
                       MinCulmen = 23,
                       MaxCulmen = 24,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 16,
                       AlphaCode = "RBGR",
                       SpeciesName = "Rose-breasted Grosbeak",
                       BandSize = "1A-2",
                       MinWing = 90,
                       MaxWing = 110,
                       MinTail = 66,
                       MaxTail = 79,
                       MinCulmen = 15.4,
                       MaxCulmen = 18.2,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 17,
                       AlphaCode = "BLJA",
                       SpeciesName = "Blue Jay",
                       BandSize = "2",
                       MinWing = 115,
                       MaxWing = 148,
                       MinTail = 106,
                       MaxTail = 148,
                       MinCulmen = 23.9,
                       MaxCulmen = 25.4,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 18,
                       AlphaCode = "DEJU",
                       SpeciesName = "Dark-eyed Junco",
                       BandSize = "0-1",
                       MinWing = 72,
                       MaxWing = 83,
                       MinTail = 62,
                       MaxTail = 74,
                       MinCulmen = 13.9,
                       MaxCulmen = 14.9,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 19,
                       AlphaCode = "EAKI",
                       SpeciesName = "Eastern Kingbird",
                       BandSize = "1B",
                       MinWing = 106,
                       MaxWing = 128,
                       MinTail = 74,
                       MaxTail = 91,
                       MinCulmen = 13.9,
                       MaxCulmen = 15,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 20,
                       AlphaCode = "RCKI",
                       SpeciesName = "Ruby-crowned Kinglet",
                       BandSize = "0A",
                       MinWing = 50,
                       MaxWing = 63,
                       MinTail = 38,
                       MaxTail = 51,
                       MinCulmen = 6,
                       MaxCulmen = 7.5,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 21,
                       AlphaCode = "GCKI",
                       SpeciesName = "Golden-crowned Kinglet",
                       BandSize = "0A",
                       MinWing = 49,
                       MaxWing = 62,
                       MinTail = 37,
                       MaxTail = 47,
                       MinCulmen = 6.25,
                       MaxCulmen = 7.5,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 22,
                       AlphaCode = "RBNU",
                       SpeciesName = "Red-breasted Nuthatch",
                       BandSize = "0",
                       MinWing = 60,
                       MaxWing =73,
                       MinTail = 33,
                       MaxTail = 39,
                       MinCulmen = 13.5,
                       MaxCulmen = 14.1,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 23,
                       AlphaCode = "WBNU",
                       SpeciesName = "White-breasted Nuthatch",
                       BandSize = "1B",
                       MinWing = 80,
                       MaxWing = 96,
                       MinTail = 39,
                       MaxTail = 52,
                       MinCulmen = 16,
                       MaxCulmen = 23,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 24,
                       AlphaCode = "BAOR",
                       SpeciesName = "Baltimore Oriole",
                       BandSize = "1A",
                       MinWing = 83,
                       MaxWing = 100,
                       MinTail = 64,
                       MaxTail = 78,
                       MinCulmen = 15.8,
                       MaxCulmen = 18.9,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 25,
                       AlphaCode = "DOWO",
                       SpeciesName = "Downy Woodpecker",
                       BandSize = "1B",
                       MinWing = 84,
                       MaxWing = 115,
                       MinTail = 48,
                       MaxTail = 72,
                       MinCulmen = 15.4,
                       MaxCulmen = 18.8,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 26,
                       AlphaCode = "OVEN",
                       SpeciesName = "Ovenbird",
                       BandSize = "1-0",
                       MinWing = 67,
                       MaxWing = 81,
                       MinTail = 48,
                       MaxTail = 57,
                       MinCulmen = 13,
                       MaxCulmen = 13.9,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 27,
                       AlphaCode = "HAWO",
                       SpeciesName = "Hairy Woodpecker",
                       BandSize = "1A-2",
                       MinWing = 107,
                       MaxWing = 138,
                       MinTail = 59,
                       MaxTail = 90,
                       MinCulmen = 24.6,
                       MaxCulmen = 33.5,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 28,
                       AlphaCode = "EAPH",
                       SpeciesName = "Eastern Phoebe",
                       BandSize = "0-1",
                       MinWing = 76,
                       MaxWing = 91,
                       MinTail = 63,
                       MaxTail = 78,
                       MinCulmen = 13,
                       MaxCulmen = 14,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 29,
                       AlphaCode = "NOCA",
                       SpeciesName = "Northern Cardinal",
                       BandSize = "1A",
                       MinWing = 82,
                       MaxWing = 105,
                       MinTail = 86,
                       MaxTail = 127,
                       MinCulmen = 15.3,
                       MaxCulmen = 18.7,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 30,
                       AlphaCode = "AMRE",
                       SpeciesName = "American Redstart",
                       BandSize = "0A-0",
                       MinWing = 55,
                       MaxWing = 69,
                       MinTail = 52,
                       MaxTail = 58,
                       MinCulmen = 7,
                       MaxCulmen = 11,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 31,
                       AlphaCode = "AMRO",
                       SpeciesName = "American Robin",
                       BandSize = "2",
                       MinWing = 115,
                       MaxWing = 145,
                       MinTail = 85,
                       MaxTail = 112,
                       MinCulmen = 20,
                       MaxCulmen = 23,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 32,
                       AlphaCode = "YBSA",
                       SpeciesName = "Yellow-bellied Sapsucker",
                       BandSize = "1B-1A",
                       MinWing = 110,
                       MaxWing = 130,
                       MinTail = 62,
                       MaxTail = 77,
                       MinCulmen = 19.3,
                       MaxCulmen = 25.2,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 33,
                       AlphaCode = "PISI",
                       SpeciesName = "Pine Siskin",
                       BandSize = "0",
                       MinWing = 66,
                       MaxWing = 77,
                       MinTail = 40,
                       MaxTail = 50,
                       MinCulmen = 8.1,
                       MaxCulmen = 9.8,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 34,
                       AlphaCode = "ATSP",
                       SpeciesName = "American Tree Sparrow",
                       BandSize = "0",
                       MinWing = 67,
                       MaxWing = 82,
                       MinTail = 60,
                       MaxTail = 74,
                       MinCulmen = 7.8,
                       MaxCulmen = 11.1,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 35,
                       AlphaCode = "LISP",
                       SpeciesName = "Lincoln Sparrow",
                       BandSize = "0",
                       MinWing = 54,
                       MaxWing = 69,
                       MinTail = 48,
                       MaxTail = 61,
                       MinCulmen = 7,
                       MaxCulmen = 11,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 36,
                       AlphaCode = "SOSP",
                       SpeciesName = "Song Sparrow",
                       BandSize = "1B",
                       MinWing = 59,
                       MaxWing = 72,
                       MinTail = 62,
                       MaxTail = 74,
                       MinCulmen = 10.3,
                       MaxCulmen = 12.6,

                   });

            builder.Entity<Species>()
                   .HasData(
                   new Species
                   {
                       SpeciesId = 37,
                       AlphaCode = "SWSP",
                       SpeciesName = "Swamp Sparrow",
                       BandSize = "1",
                       MinWing = 52,
                       MaxWing = 65,
                       MinTail = 51,
                       MaxTail = 64,
                       MinCulmen = 7,
                       MaxCulmen = 11,

                   });
        }
    }
}
