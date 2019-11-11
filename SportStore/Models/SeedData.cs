using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext contex = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            contex.Database.Migrate();
            if (!contex.Products.Any())
            {
                contex.Products.AddRange(

                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                 new Product
                 {
                     Name = "Lifejacket",
                     Description = "Protective and fashionable",
                     Category = "Watersports",
                     Price = 48.95m
                 },
                 new Product
                 {
                     Name = "Soccer Ball",
                     Description = "FIFA-approved size and weight",
                     Category = "Soccer",
                     Price = 19.50m
                 },
                 new Product
                 {
                     Name = "Corner Flags",
                     Description = "Give your playing field a professional touch",
                     Category = "Soccer",
                     Price = 34.95m
                 },
                 new Product
                 {
                     Name = "Stadium",
                     Description = "Flat-packed 35,000-seat stadium",
                     Category = "Soccer",
                     Price = 79500
                 },
                 new Product
                 {
                     Name = "Thinking Cap",
                     Description = "Improve brain efficiency by 75%",
                     Category = "Chess",
                     Price = 16
                 },
                 new Product
                 {
                     Name = "Unsteady Chair",
                     Description = "Secretly give your opponent a disadvantage",
                     Category = "Chess",
                     Price = 29.95m
                 },
                    new Product
                    {
                        Name = "Thinking Сар",
                        Description = "Improve brain efficiency Ьу 75i",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent а disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    },

                    new Product
                    {
                        Name = "Human Chess Board",
                        Description = "А fun game for the family",
                        Category = "Chess",
                        Price = 75
                    },

                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess",
                    }
                );
                contex.SaveChanges();
            }
        }
    }
}

