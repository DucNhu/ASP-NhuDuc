using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace _5_1_test.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new product
                    {
                        Name = "Kaydc",
                        Des = "A botat for one person",
                        Category = "Watersports",
                        Price = 275
                    });
                context.SaveChanges();
            }
        }
    }
}
