using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VogCodeChallenge.API.Controllers
{
    public class NEmployeeController : Controller
    {
        EmployeeController empController = new EmployeeController();
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IEnumerable<Employee> GetAll()
        {
            return empController.GetAll();
        }

        public IList<Employee> ListAll()
        {
            return (empController.GetAll()).ToList();
        }
    }
}
