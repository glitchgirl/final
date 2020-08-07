using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Smtih_Midterm.Models
{
    public class HouseContext : DbContext
    {
        public HouseContext(DbContextOptions<HouseContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Info> Infos { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Photos> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Region>().HasData(
                new Region { RegionId = 1, Name = "Richmond" },
                new Region { RegionId = 2, Name = "Columbia" },
                new Region { RegionId = 3, Name = "Coffee" }
            );
            modelBuilder.Entity<Photos>().HasData(
                new Photos { PhotoFilter = 1, Pic1 = "bathroom1.jpg", Pic2 = "bedroom1.jpg", Pic3 = "kitchen1.jpg"},
                new Photos { PhotoFilter = 2, Pic1 = "bathroom2.jpg", Pic2 = "bedroom2.jpg", Pic3 = "kitchen2.jpg" },
                new Photos { PhotoFilter = 3, Pic1 = "bathroom3.jpg", Pic2 = "bedroom3.jpg", Pic3 = "kitchen3.jpg" },
                new Photos { PhotoFilter = 4, Pic1 = "bathroom4.jpg", Pic2 = "bedroom4.jpg", Pic3 = "kitchen4.jpg" },
                new Photos { PhotoFilter = 5, Pic1 = "bathroom5.jpg", Pic2 = "bedroom5.jpg", Pic3 = "kitchen5.jpg" },
                new Photos { PhotoFilter = 6, Pic1 = "bathroom6.jpg", Pic2 = "bedroom6.jpg", Pic3 = "kitchen6.jpg" },
                new Photos { PhotoFilter = 7, Pic1 = "bathroom7.jpg", Pic2 = "bedroom7.jpg", Pic3 = "kitchen7.jpg" },
                new Photos { PhotoFilter = 8, Pic1 = "bathroom8.jpg", Pic2 = "bedroom8.jpg", Pic3 = "kitchen8.jpg" },
                new Photos { PhotoFilter = 9, Pic1 = "bathroom9.jpg", Pic2 = "bedroom9.jpg", Pic3 = "kitchen9.jpg" },
                new Photos { PhotoFilter = 10, Pic1 = "bathroom10.jpg", Pic2 = "bedroom10.jpg", Pic3 = "kitchen10.jpg" },
                new Photos { PhotoFilter = 11, Pic1 = "bathroom11.jpg", Pic2 = "bedroom11.jpg", Pic3 = "kitchen11.jpg" },
                new Photos { PhotoFilter = 12, Pic1 = "bathroom12.jpg", Pic2 = "bedroom12.jpg", Pic3 = "kitchen12.jpg" }
            );
            modelBuilder.Entity<Info>().HasData(
                new Info
                {
                    HouseId=1,
                    PhotoFilter=1,
                    Address= "4340 Peach Orchard Rd, Hephzibah, GA 30815",
                    BathCount=3,
                    BedRCount=7,
                    SqFt= 5726,
                    Year=1929,

                    Heating="Forced air, Heat pump",
                    AC="Central",

                    CodeOut="out1.jpg",
                    RegionId=1,
                    Price=325000
                },
                new Info
                {
                    HouseId = 2,
                    PhotoFilter=2,
                    Address = "1105 Fawn Forest Rd, Grovetown, GA",
                    BathCount = 3,
                    BedRCount = 5,
                    SqFt = 3371,
                    Year = 2018,

                    Heating = "Heat pump",
                    AC = "Central",

                    CodeOut = "out2.jpg",
                    RegionId = 2,
                    Price = 300000
                },
                new Info
                {
                    HouseId = 3,
                    PhotoFilter = 3,
                    Address = "740 Meadow Hill Dr, Grovetown, GA",
                    BathCount = 2,
                    BedRCount = 3,
                    SqFt = 1800,
                    Year = 2018,

                    Heating = "Heat pump",
                    AC = "No Data",

                    CodeOut = "out3.jpg",
                    RegionId = 2,
                    Price = 250000
                },
                new Info
                {
                    HouseId = 4,
                    PhotoFilter = 4,
                    Address = "325 Crown Heights Way, Grovetown, GA",
                    BathCount = 2,
                    BedRCount = 4,
                    SqFt = 1691,
                    Year = 2015,

                    Heating = "Heat pump",
                    AC = "Central",

                    CodeOut = "out4.jpg",
                    RegionId = 2,
                    Price = 204900
                },
                new Info
                {
                    HouseId = 5,
                    PhotoFilter = 5,
                    Address = "535 Oak Brook Dr, Martinez, GA",
                    BathCount = 3,
                    BedRCount = 4,
                    SqFt = 2106,
                    Year = 1993,

                    Heating = "Forced air",
                    AC = "No Data",

                    CodeOut = "out5.jpg",
                    RegionId = 2,
                    Price = 239900
                },
                new Info
                {
                    HouseId = 6,
                    PhotoFilter = 6,
                    Address = "213 Gardners Mill Rd, Augusta, GA",
                    BathCount = 2,
                    BedRCount = 4,
                    SqFt = 2256,
                    Year = 1972,

                    Heating = "Forced air",
                    AC = "Central",

                    CodeOut = "out6.jpg",
                    RegionId = 1,
                    Price = 210000
                },
                new Info
                {
                    HouseId = 7,
                    PhotoFilter = 7,
                    Address = "3335 Wedgewood Dr, Augusta, GA ",
                    BathCount = 2,
                    BedRCount = 3,
                    SqFt = 1452,
                    Year = 1956,

                    Heating = "Forced air",
                    AC = "No Data",

                    CodeOut = "out7.jpg",
                    RegionId = 1,
                    Price = 149900
                },
                new Info
                {
                    HouseId = 8,
                    PhotoFilter = 8,
                    Address = "4221 Rose Hill Dr, Hephzibah, GA ",
                    BathCount = 2,
                    BedRCount = 3,
                    SqFt = 1415,
                    Year = 1989,

                    Heating = "Forced air",
                    AC = "Central",

                    CodeOut = "out8.jpg",
                    RegionId = 1,
                    Price = 124900
                },
                new Info
                {
                    HouseId = 9,
                    PhotoFilter = 9,
                    Address = "1220 Green Hollow Run, Douglas, GA",
                    BathCount = 3,
                    BedRCount = 4,
                    SqFt = 2441,
                    Year = 1989,

                    Heating = "Heat Pump",
                    AC = "Central",

                    CodeOut = "out9.jpg",
                    RegionId = 3,
                    Price = 249900
                },
                new Info
                {
                    HouseId = 10,
                    PhotoFilter = 10,
                    Address = "215 Gaskin Ave N, Douglas, GA",
                    BathCount = 3,
                    BedRCount = 4,
                    SqFt = 3662,
                    Year = 1898,

                    Heating = "Other",
                    AC = "Central",

                    CodeOut = "out10.jpg",
                    RegionId = 3,
                    Price = 229000
                },
                new Info
                {
                    HouseId = 11,
                    PhotoFilter = 11,
                    Address = "1807 Robin Ln, Douglas, GA",
                    BathCount = 5,
                    BedRCount = 4,
                    SqFt = 34046,
                    Year = 1992,

                    Heating = "Heat Pump, Other",
                    AC = "Central",

                    CodeOut = "out11.jpg",
                    RegionId = 3,
                    Price = 224000
                },
                new Info
                {
                    HouseId = 12,
                    PhotoFilter = 12,
                    Address = "445 Westwood Heights Cir, Douglas, GA",
                    BathCount = 4,
                    BedRCount = 5,
                    SqFt = 3846,
                    Year = 1989,

                    Heating = "Heat Pump, Other",
                    AC = "Central",

                    CodeOut = "out12.jpg",
                    RegionId = 3,
                    Price = 350000
                }
            );
        }
    }
}

