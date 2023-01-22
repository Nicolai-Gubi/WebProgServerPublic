using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ShoppingList.Models
{
    public class ItemDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new ItemDbContext(serviceProvider.GetRequiredService<DbContextOptions<ItemDbContext>>());

            //Look for any items.
            if (context.Items.Any())
            {
                // If we get here then the data is already seeded.
                return;

            }

            context.Items.AddRange(
                new Item
                {
                    Id = 1,
                    ItemName = "Kaffe",
                    Amount = 2,
                    UnitType = (UnitList)5,
                    Department = (DepartmentList)5
                },
                new Item
                {
                    Id = 2,
                    ItemName = "Mælk",
                    Amount = 1,
                    UnitType = (UnitList)4,
                    Department = (DepartmentList)1
                }
            );
            context.SaveChanges();
        }
    }
}
