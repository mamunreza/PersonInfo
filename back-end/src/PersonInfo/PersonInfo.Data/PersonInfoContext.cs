﻿using Microsoft.EntityFrameworkCore;
using PersonInfo.Data.Model;

namespace PersonInfo.Data
{
    public class PersonInfoContext : DbContext
    {
        public PersonInfoContext(DbContextOptions<PersonInfoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedDb(modelBuilder);
        }

        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Person> Persons { get; set; }

        private static void SeedDb(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sector>().HasData(
                new List<Sector>
                {
                    new()
                    {
                        Id = -1,
                        Name = "Select Sector",
                        ParentId = -1
                    },
                    new()
                    {
                        Id = 1,
                        Name = "Manufacturing",
                        ParentId = -1
                    },
                    new()
                    {
                        Id = 2,
                        Name = "Construction materials",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 3,
                        Name = "Electronics and Optics",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 4,
                        Name = "Food and Beverage",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 5,
                        Name = "Bakery & confectionery products",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 6,
                        Name = "Beverages",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 7,
                        Name = "Fish & fish products",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 8,
                        Name = "Meat & meat products",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 9,
                        Name = "Milk & dairy products",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 10,
                        Name = "Other",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 11,
                        Name = "Sweets & snack food",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 12,
                        Name = "Furniture",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 13,
                        Name = "Bathroom/sauna",
                        ParentId = 12
                    },
                    new()
                    {
                        Id = 14,
                        Name = "Bedroom",
                        ParentId = 12
                    },
                    new()
                    {
                        Id = 15,
                        Name = "Children's room",
                        ParentId = 12
                    },
                    new()
                    {
                        Id = 16,
                        Name = "Kitchen",
                        ParentId = 12
                    },
                    new()
                    {
                        Id = 17,
                        Name = "Living room",
                        ParentId = 12
                    },
                    new()
                    {
                        Id = 18,
                        Name = "Office",
                        ParentId = 12
                    },
                    new()
                    {
                        Id = 19,
                        Name = "Other (Furniture)",
                        ParentId = 12
                    },
                    new()
                    {
                        Id = 20,
                        Name = "Outdoor",
                        ParentId = 12
                    },
                    new()
                    {
                        Id = 21,
                        Name = "Project furniture",
                        ParentId = 12
                    },
                    new()
                    {
                        Id = 22,
                        Name = "Machinery",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 23,
                        Name = "Machinery components",
                        ParentId = 22
                    },
                    new()
                    {
                        Id = 24,
                        Name = "Machinery equipment/tools",
                        ParentId = 22
                    },
                    new()
                    {
                        Id = 25,
                        Name = "Manufacture of machinery",
                        ParentId = 22
                    },
                    new()
                    {
                        Id = 26,
                        Name = "Maritime",
                        ParentId = 22
                    },
                    new()
                    {
                        Id = 27,
                        Name = "Aluminium and steel workboats",
                        ParentId = 26
                    },
                    new()
                    {
                        Id = 28,
                        Name = "Boat/Yacht building",
                        ParentId = 26
                    },
                    new()
                    {
                        Id = 29,
                        Name = "Ship repair and conversion",
                        ParentId = 26
                    },
                    new()
                    {
                        Id = 30,
                        Name = "Metal structures",
                        ParentId = 22
                    },
                    new()
                    {
                        Id = 31,
                        Name = "Other",
                        ParentId = 22
                    },
                    new()
                    {
                        Id = 32,
                        Name = "Repair and maintenance service",
                        ParentId = 22
                    },
                    new()
                    {
                        Id = 33,
                        Name = "Metalworking",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 34,
                        Name = "Construction of metal structures",
                        ParentId = 33
                    },
                    new()
                    {
                        Id = 35,
                        Name = "Houses and buildings",
                        ParentId = 33
                    },
                    new()
                    {
                        Id = 36,
                        Name = "Metal products",
                        ParentId = 33
                    },
                    new()
                    {
                        Id = 37,
                        Name = "Metal works",
                        ParentId = 33
                    },
                    new()
                    {
                        Id = 38,
                        Name = "CNC-machining",
                        ParentId = 37
                    },
                    new()
                    {
                        Id = 39,
                        Name = "Forgings, Fasteners",
                        ParentId = 37
                    },
                    new()
                    {
                        Id = 40,
                        Name = "Gas, Plasma, Laser cutting",
                        ParentId = 37
                    },
                    new()
                    {
                        Id = 41,
                        Name = "MIG, TIG, Aluminum welding",
                        ParentId = 37
                    },
                    new()
                    {
                        Id = 42,
                        Name = "Plastic and Rubber",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 43,
                        Name = "Packaging",
                        ParentId = 42
                    },
                    new()
                    {
                        Id = 44,
                        Name = "Plastic goods",
                        ParentId = 42
                    },
                    new()
                    {
                        Id = 45,
                        Name = "Plastic processing technology",
                        ParentId = 42
                    },
                    new()
                    {
                        Id = 46,
                        Name = "Blowing",
                        ParentId = 45
                    },
                    new()
                    {
                        Id = 47,
                        Name = "Moulding",
                        ParentId = 45
                    },
                    new()
                    {
                        Id = 48,
                        Name = "Plastics welding and processing",
                        ParentId = 45
                    },
                    new()
                    {
                        Id = 49,
                        Name = "Plastic profiles",
                        ParentId = 42
                    },
                    new()
                    {
                        Id = 50,
                        Name = "Printing",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 51,
                        Name = "Advertising",
                        ParentId = 50
                    },
                    new()
                    {
                        Id = 52,
                        Name = "Book/Periodicals printing",
                        ParentId = 50
                    },
                    new()
                    {
                        Id = 53,
                        Name = "Labelling and packaging printing",
                        ParentId = 50
                    },
                    new()
                    {
                        Id = 54,
                        Name = "Textile and Clothing",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 55,
                        Name = "Clothing",
                        ParentId = 54
                    },
                    new()
                    {
                        Id = 56,
                        Name = "Textile",
                        ParentId = 54
                    },
                    new()
                    {
                        Id = 57,
                        Name = "Wood",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 58,
                        Name = "Other (Wood)",
                        ParentId = 57
                    },
                    new()
                    {
                        Id = 59,
                        Name = "Wooden building materials",
                        ParentId = 57
                    },
                    new()
                    {
                        Id = 60,
                        Name = "Wooden houses",
                        ParentId = 57
                    },
                    new()
                    {
                        Id = 61,
                        Name = "Other",
                        ParentId = -1
                    },
                    new()
                    {
                        Id = 62,
                        Name = "Creative industries",
                        ParentId = 61
                    },
                    new()
                    {
                        Id = 63,
                        Name = "Energy technology",
                        ParentId = 61
                    },
                    new()
                    {
                        Id = 64,
                        Name = "Environment",
                        ParentId = 61
                    },
                    new()
                    {
                        Id = 65,
                        Name = "Service",
                        ParentId = -1
                    },
                    new()
                    {
                        Id = 66,
                        Name = "Business services",
                        ParentId = 65
                    },
                    new()
                    {
                        Id = 67,
                        Name = "Engineering",
                        ParentId = 65
                    },
                    new()
                    {
                        Id = 68,
                        Name = "Information Technology and Telecommunications",
                        ParentId = 65
                    },
                    new()
                    {
                        Id = 69,
                        Name = "Data processing, Web portals, E-marketing",
                        ParentId = 68
                    },
                    new()
                    {
                        Id = 70,
                        Name = "Programming, Consultancy",
                        ParentId = 68
                    },
                    new()
                    {
                        Id = 71,
                        Name = "Software, Hardware",
                        ParentId = 68
                    },
                    new()
                    {
                        Id = 72,
                        Name = "Telecommunications",
                        ParentId = 68
                    },
                    new()
                    {
                        Id = 73,
                        Name = "Tourism",
                        ParentId = 65
                    },
                    new()
                    {
                        Id = 74,
                        Name = "Translation services",
                        ParentId = 65
                    },
                    new()
                    {
                        Id = 75,
                        Name = "Transport and Logistics",
                        ParentId = 65
                    },
                    new()
                    {
                        Id = 76,
                        Name = "Air",
                        ParentId = 75
                    },
                    new()
                    {
                        Id = 77,
                        Name = "Rail",
                        ParentId = 75
                    },
                    new()
                    {
                        Id = 78,
                        Name = "Road",
                        ParentId = 75
                    },
                    new()
                    {
                        Id = 79,
                        Name = "Water",
                        ParentId = 75
                    }
                }
            );
        }
    }
}



/*
new()
                    {
                        Id = 1,
                        Name = "Manufacturing",
                        ParentId = 0
                    },
                    new()
                    {
                        Id = 2,
                        Name = "Construction materials",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 3,
                        Name = "Electronics and Optics",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 4,
                        Name = "Food and Beverage",
                        ParentId = 1
                    },
                    new()
                    {
                        Id = 5,
                        Name = "Bakery & confectionery products",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 6,
                        Name = "Beverages",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 7,
                        Name = "Fish & fish products",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 8,
                        Name = "Meat & meat products",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 9,
                        Name = "Milk & dairy products",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 10,
                        Name = "Other",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 11,
                        Name = "Sweets & snack food",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 11,
                        Name = "Sweets & snack food",
                        ParentId = 4
                    },
                    new()
                    {
                        Id = 11,
                        Name = "Sweets & snack food",
                        ParentId = 4
                    }
 */