using CommonObjects.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderAPI.Services;
using System.Collections.Generic;
using System.Linq;
namespace OrderAPI.Controllers
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
        /// get orders here
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("GetOrders")]
        public IEnumerable<Dropdown_d> GetOrders()
        {
            return new OrderService().GetOrders().Select(r => new Dropdown_d { Id = r.Id, Name = r.Number });
        }
    }
}
