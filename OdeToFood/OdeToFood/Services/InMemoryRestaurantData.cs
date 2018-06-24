using OdeToFood.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza Place" },
                new Restaurant { Id = 2, Name = "Tersiguels" },
                new Restaurant { Id = 3, Name = "King's Contrivance" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Restaurant Add(Restaurant restaurant)
        {
            throw new System.NotImplementedException();
        }

        private List<Restaurant> _restaurants;

    }
}
