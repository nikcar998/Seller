using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Items.Any()) return;

            var items = new List<Item>
            {
                new Item 
                {
                   Title = "Bike",
                   Description = "Mountain Bike",
                   Publisher = "Nico",
                   Cost = 100.00,
                   Phone = 123456789,
                   Location = "Palermo,PA,Sicily,Italy",
                   Date= DateTime.Now.AddMonths(-1),
                   Category="Bikes"
                },
                 new Item 
                {
                   Title = "ActionMan",
                   Description = "A simple doll",
                   Publisher = "Nico",
                   Cost = 10.50,
                   Phone = 123456789,
                   Location = "Palermo,PA,Sicily,Italy",
                   Date= DateTime.Now.AddMonths(1),
                   Category="Toys"
                },
                 new Item 
                {
                   Title = "Computer hp-gaming",
                   Description = "The perfect laptop for great players",
                   Publisher = "Nico",
                   Cost = 1500.00,
                   Phone = 123456789,
                   Location = "Palermo,PA,Sicily,Italy",
                   Date= DateTime.Now.AddMonths(-2),
                   Category="Electronics"
                },
                 new Item 
                {
                   Title = "Dishwasher",
                   Description = "Agreat dishwasher!",
                   Publisher = "Nico",
                   Cost = 899.00,
                   Phone = 123456789,
                   Location = "Palermo,PA,Sicily,Italy",
                   Date= DateTime.Now.AddMonths(0),
                   Category="Electronics"
                },
                 new Item 
                {
                   Title = "Bikes",
                   Description = "City Bikes",
                   Publisher = "Nico",
                   Cost = 320.00,
                   Phone = 123456789,
                   Location = "Palermo,PA,Sicily,Italy",
                   Date= DateTime.Now.AddMonths(-1),
                   Category="Bike"
                },
                 new Item 
                {
                   Title = "City car",
                   Description = "That's the perfect city-car!",
                   Publisher = "Nico",
                   Cost = 10000.00,
                   Phone = 123456789,
                   Location = "Palermo,PA,Sicily,Italy",
                   Date= DateTime.Now.AddMonths(-3),
                   Category="Cars"
                },
                 new Item 
                {
                   Title = "Jeep",
                   Description = "The strongest jeep",
                   Publisher = "Nico",
                   Cost = 100.00,
                   Phone = 123456789,
                   Location = "Palermo,PA,Sicily,Italy",
                   Date= DateTime.Now.AddMonths(-1),
                   Category="Cars"
                }                              
            };
            await context.Items.AddRangeAsync(items);
            await context.SaveChangesAsync();
        }
    }
}