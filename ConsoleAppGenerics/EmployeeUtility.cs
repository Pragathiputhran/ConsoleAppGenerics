using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGenerics
{
    internal class EmployeeUtility
    {
        public List<Employee> Employees { get; set; }

        public EmployeeUtility()
        {
            Employees = new List<Employee>();
        }
        public void InsertEmployee(Employee employee)
        {
            this.Employees.Add(employee);
        }
        public void DisplayEmployees()
        {
            foreach (Employee item in this.Employees)
            {
                Console.WriteLine(item.Name);
            }
        }
        
    }
}
