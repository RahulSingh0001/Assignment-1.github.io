﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantAPI.Services;
using RestaurantEntities.Entities;
using System.Collections.Generic;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly ILogger<RestaurantController> _logger;

        public RestaurantController(ILogger<RestaurantController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get restaurants here 
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetRestaurants")]
        public IEnumerable<Restaurant> Get()
        {
            return new RestaurantService().GetRestaurants();
        }

        /// <summary>
        /// Add restaurant here
        /// </summary>
        /// <param name="d">request d</param>
        /// <returns>response d</returns>
        [HttpGet, Route("GetMenu/{id}")]
        public RestaurantMenu GetRestaurantMenu(long id)
        {
            return new RestaurantService().GetMenu(id: id);
        }
    }
}
