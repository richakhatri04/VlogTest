using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        string[] fn = { "John", "Marry", "Jen", "Alex", "Mary" };
        string[] ln = { "Doe", "Maxwell", "Russo", "Mathew", "Khatri" };
        string[] jt = { "CEO", "DFO", "RM", "SDFO", "GM" };
   string[] address = { "Young st", "Barrington st", "South st", "North End", "West End" };

        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            
            return Enumerable.Range(1, 5).Select(index => new Employee
            {
                emplyoeeId = index,
                firstName = fn[index-1],
                lastName=ln[index-1],
                jobTitle=jt[index-1],
                address=address[index-1]
            })
            .ToArray();
        }
        [HttpGet]
        [Route("/department/{departmentId}")]
        public IEnumerable<Employee> GetEmployeeByDeptId(int departmentId)
        {
            NEmployeeController emp = new NEmployeeController();
            List<Employee> empList = emp.ListAll().ToList();
            var employee=empList.Where(e => e.empdepartmentId == departmentId).ToList();
            return employee;
        }
    }
}
