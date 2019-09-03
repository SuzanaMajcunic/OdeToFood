using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Data.Models;

namespace OdeToFood.Data.Services
{
    public class InMemoryResaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        // SHORTCUT: ctor
        public InMemoryResaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id=1, Name="Suzy's pizza", Cuisine = CuisineType.Italian },
                new Restaurant { Id=2, Name="Destino", Cuisine = CuisineType.French },
                new Restaurant { Id=1, Name="Rajesh finest food", Cuisine = CuisineType.Indian }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
