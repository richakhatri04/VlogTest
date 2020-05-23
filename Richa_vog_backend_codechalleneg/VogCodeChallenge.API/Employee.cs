using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API
{
    public class Employee
    {
        public int emplyoeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string jobTitle { get; set; }
        public string address { get; set; }

        public int empdepartmentId { get; set; }
    }
}
