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
                new Restaurant { Id=3, Name="Rajesh finest food", Cuisine = CuisineType.Indian }
            };
        }

        public Restaurant Get(int id)
        {
            // get reference on first value or get default (NULL) value
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
