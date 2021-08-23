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
            if (context.Business.Any()) return;

            var business = new List<Commerce>
            {
                new Commerce
                {
                    Name = "Store the Eagle",
                    CUIT = "AA-12345678-B",
                    Concept1 = 5,
                    Concept2 = 5,
                    Concept3 = 4,
                    Concept4 = 2,
                    Concept5 = 7,
                    Concept6 = 8,
                    CurrentBalance = 345,
                    Active = true,
                    LastSale = DateTime.Now.AddMonths(-2),
                },
                new Commerce
                {
                    Name = "Store of candys",
                    CUIT = "HE-123SX678-B",
                    Concept1 = 7,
                    Concept2 = 6,
                    Concept3 = 9,
                    Concept4 = 9,
                    Concept5 = 7,
                    Concept6 = 2,
                    CurrentBalance = 725,
                    Active = true,
                    LastSale = DateTime.Now.AddMonths(-1),
                },
                new Commerce
                {
                    Name = "Iron and Steel Commerce",
                    CUIT = "AP4-12345678-B",
                    Concept1 = 4,
                    Concept2 = 4,
                    Concept3 = 4,
                    Concept4 = 7,
                    Concept5 = 1,
                    Concept6 = 8,
                    CurrentBalance = 1215,
                    Active = true,
                    LastSale = DateTime.Now.AddMonths(1),
                },
                new Commerce
                {
                    Name = "Clothes and Colors",
                    CUIT = "AA-12345Z78-B",
                    Concept1 = 3,
                    Concept2 = 5,
                    Concept3 = 4,
                    Concept4 = 1,
                    Concept5 = 7,
                    Concept6 = 3,
                    CurrentBalance = 115,
                    Active = false,
                    LastSale = DateTime.Now.AddMonths(2),
                },
                new Commerce
                {
                    Name = "Store of Chip Fries",
                    CUIT = "DD-12345678-Z",
                    Concept1 = 5,
                    Concept2 = 1,
                    Concept3 = 1,
                    Concept4 = 4,
                    Concept5 = 3,
                    Concept6 = 5,
                    CurrentBalance = 35,
                    Active = false,
                    LastSale = DateTime.Now.AddMonths(3),
                },
                new Commerce
                {
                    Name = "Store the Tiger Light",
                    CUIT = "TT-45445678-L",
                    Concept1 = 3,
                    Concept2 = 2,
                    Concept3 = 5,
                    Concept4 = 6,
                    Concept5 = 6,
                    Concept6 = 1,
                    CurrentBalance = 542,
                    Active = true,
                    LastSale = DateTime.Now.AddMonths(4),
                },
                new Commerce
                {
                    Name = "Battery Commerce",
                    CUIT = "RT-16745678-S",
                    Concept1 = 2,
                    Concept2 = 1,
                    Concept3 = 4,
                    Concept4 = 2,
                    Concept5 = 7,
                    Concept6 = 4,
                    CurrentBalance = 565,
                    Active = true,
                    LastSale = DateTime.Now.AddMonths(5),
                },
            };
            await context.Business.AddRangeAsync(business);
            await context.SaveChangesAsync();
        }
    }
}