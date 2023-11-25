using Microsoft.Extensions.DependencyInjection;
using shopdemo.Data.Model;

namespace shopdemo.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Items.Any())
                {
                    context.Items.AddRange(new Item()
                    {
                        Name = "Hiep",
                        Price = 2,
                        Quantity =10,

                    }, new Item()
                    {

                        Name = "Spiderman",
                        Price = 3,
                        Quantity = 90,
                    },new Item()
                    {
                        Name = "Hiep123", 
                        Price = 5, 
                        Quantity = 12
                    }
                    );
                    context.SaveChanges();
                }
            }
              

            
        }
    }
}
