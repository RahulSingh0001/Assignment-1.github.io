using Business;
using Business.Interface;
using BusinessEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager _EmployeeManager;
        private readonly ILogger _logger;

        public EmployeeController(IEmployeeManager EmployeeManager, ILoggerFactory logger)
        {
            _EmployeeManager = EmployeeManager;
            _logger = logger.CreateLogger("MyCategory");
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, _EmployeeManager.GetAllEmployees().ToList());
        }
        [HttpGet, Route("GetEmployee/{id}")]
        public ActionResult GetEmployee(int id)
        {
            return StatusCode(200, _EmployeeManager.GetEmployee(id));
        }
        [HttpPost]
        [Route("PostEmployee")]
        public ActionResult PostHotel([FromBody] EmployeeViewModel employee)
        {
            return StatusCode(201,_EmployeeManager.CreateEmployee(employee));
        }
        [HttpPut]
        [Route("PutEmployee/{id}")]
        public ActionResult PutHotel(int id, [FromBody] EmployeeViewModel employee)
        {
            return StatusCode(201,_EmployeeManager.UpdateEmployee(employee));
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            return StatusCode(201, _EmployeeManager.DeleteEmployee(id));
        }
    }
}
