using CommonObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantAPI.Services;
using System.Collections.Generic;
using System.Linq;
namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DropdownController : ControllerBase
    {
        private readonly ILogger<DropdownController> _logger;

        public DropdownController(ILogger<DropdownController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get details of foods here
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetFoods")]
        public IEnumerable<Dropdown_d> GetFoods()
        {
            return new FoodService().GetFoods().Select(r => new Dropdown_d { Id = r.Id, Name = r.Name });
        }

        /// <summary>
        ///  Get details of resturant here
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetRestaurants")]
        public IEnumerable<Dropdown_d> GetRestaurants()
        {
            return new RestaurantService().GetRestaurants().Select(r => new Dropdown_d { Id = r.Id, Name = r.Name });
        }
    }
}
