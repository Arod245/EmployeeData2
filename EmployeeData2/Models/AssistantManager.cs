using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeData2.Models
{
    public class AssistantManager
    {
        public int EmployeeNum { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public AssistantManager() 
        {
            Employees emp = new Employees();
            EmployeeNum = emp.EmployeeNum;
            FirstName = emp.FirstName;
            Lastname = emp.Lastname;

        }


    }
}
