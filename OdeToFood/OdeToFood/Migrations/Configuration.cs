namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDB context)
        {
           context.Restaurants.AddOrUpdate(
                  p => p.Name,
                  new Restaurant { Name = "G54",City="Hyderabad", Country="IND" },
                  new Restaurant { Name = "Hyderabad House", City = "Hyderabad", Country = "IND" },
                  new Restaurant { Name = "Delhi 36", City = "Hyderabad", Country = "IND", 
                  
                      Reviews= new List<RestaurantReview> {
                          new RestaurantReview {Rating=9, Body="Great food!", ReviewerName="Eni"}
                      }
                  }
                );
            
        }
    }
}
