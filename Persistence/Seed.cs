using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            // If Already Found - Exit
            if (context.Couriers.Any()) { return; }

            // Default Couriers [Listed In Requirements]
            var CouriersData = new List<Courier>
            {
                new Courier
                {
                    CourierName = "Cargo4You",
                    ParcelWeightKgMin = 0,
                    ParcelWeightKgMax = 20,
                    ParcelDimensionCmMin = 0,
                    ParcelDimensionCmMax = 2000,
                    ParcelDimensionsPricing =  new List<ParcelDimensionsPricing>()
                    {
                        new ParcelDimensionsPricing()
                        {
                            ParcelDimensionsCmFrom = 0,
                            ParcelDimensionsCmTo = 1000,
                            ParcelDimensionsPrice = 10
                        }
                    }
                },
                new Courier
                {
                    CourierName = "ShipFaster",
                    ParcelWeightKgMin = 10,
                    ParcelWeightKgMax = 30,
                    ParcelDimensionCmMin = 0,
                    ParcelDimensionCmMax = 1700
                },
                new Courier
                {
                    CourierName = "MaltaShip",
                    ParcelWeightKgMin = 0,
                    ParcelWeightKgMax = 10,
                    ParcelDimensionCmMin = 500,
                    ParcelDimensionCmMax = -1
                }
            };

            // Add Default Couriers - [Listed In Requirements]
            await context.Couriers.AddRangeAsync(CouriersData);

            // Save Changes
            await context.SaveChangesAsync();
        }
    }
}
