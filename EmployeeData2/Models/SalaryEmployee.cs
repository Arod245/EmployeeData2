using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeData2.Models
{
    public class SalaryEmployee
    {
        public List<Employees> emp = new List<Employees>();
        public double Salary { get; set; }

        public void AssignSalary() 
        {
            foreach (var i in emp) 
            {
                i.salary = Salary;
                
            }
        }
    }
}
