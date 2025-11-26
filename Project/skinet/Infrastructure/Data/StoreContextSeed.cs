using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if (!context.Products.Any())
            {
                var productsData = await File.ReadAllTextAsync("../Infrastructure/Data/products.json");

                var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                if (products == null)
                {
                    return;
                }

                context.Products.AddRange(products); //AddRange adds multiple entities at once
                await context.SaveChangesAsync();
            }

            if (!context.DeliveryMethods.Any())
            {
                var dmData = await File.ReadAllTextAsync("../Infrastructure/Data/delivery.json");

                var methods = JsonSerializer.Deserialize<List<DeliveryMethod>>(dmData);

                if (methods == null)
                {
                    return;
                }

                context.DeliveryMethods.AddRange(methods); //AddRange adds multiple entities at once
                await context.SaveChangesAsync();
            }
        }
    }
}
