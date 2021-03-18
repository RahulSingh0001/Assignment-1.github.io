using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomTag.Models;
using Microsoft.AspNetCore.Mvc;


namespace CustomTag.Controllers
{
    public class EmployeeController : Controller
    {
        private const long V = 7979988172;

        public long Number { get; private set; }

        public IActionResult Index()
        {
            Employee e = new Employee();
            e.Name = "Rahul Singh";
            e.Number = "undefined";


            return View(e);
        }


    }
}