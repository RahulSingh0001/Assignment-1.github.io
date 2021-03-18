using RestaurantEntities.Entities;
using RestaurantEntities.Enum;
using System.Collections.Generic;

namespace RestaurantAPI.Services
{
    public class FoodService
    {
        public List<Food> GetFoods()
        {
            var foods = new List<Food>();
            for (int i = 8; i <= 15; i++)
            {
                foods.Add(new Food
                {
                    Id = i,
                    Name = $"Food_{i}",
                    Type = FoodEnum.Indian,
                });
            }
            return foods;
        }
    }
}
