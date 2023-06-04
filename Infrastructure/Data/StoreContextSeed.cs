using Core.Entities;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Infrastructure.Data;
public class StoreContextSeed
{
    public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
    {
		try
		{
			if (!context.ProductBrands.Any())
			{
				var brandsdData = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
				var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsdData);

				foreach (var item in brands)
				{
					context.ProductBrands.Add(item);
				}
				await context.SaveChangesAsync();
			}


            // Product Types
            if (!context.ProductTypes.Any())
            {
                var brandsType = File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
                var types = JsonSerializer.Deserialize<List<ProductType>>(brandsType);

                foreach (var item in types)
                {
                    context.ProductTypes.Add(item);
                }
                await context.SaveChangesAsync();
            }

            // Products
            if (!context.Products.Any())
            {
                var products = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
                var lstProducts = JsonSerializer.Deserialize<List<Products>>(products);

                foreach (var item in lstProducts)
                {
                    context.Products.Add(item);
                }
                await context.SaveChangesAsync();
            }
        }
		catch (Exception ex)
		{

            var logger = loggerFactory.CreateLogger<StoreContextSeed>();
            logger.LogError(ex.Message);
		}
    }
}
