using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_CoStrateix.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }

        public static List<Employee> GetAllEmployees() {
            return new List<Employee>() { 
                new Employee { EmployeeId = 1, EmployeeCode = "E001", FirstName = "Jhon",LastName="Smith", DepartmentId= 1},
                new Employee { EmployeeId = 2, EmployeeCode = "E002", FirstName = "Ben",LastName="Smith", DepartmentId= 2},
                new Employee { EmployeeId = 3, EmployeeCode = "E003", FirstName = "Ken",LastName="David", DepartmentId= 1},
                new Employee { EmployeeId = 4, EmployeeCode = "E004", FirstName = "Robert",LastName="Smith", DepartmentId= 2},
                new Employee { EmployeeId = 5, EmployeeCode = "E005", FirstName = "Mery",LastName="Smith", DepartmentId= 3},
                new Employee { EmployeeId = 6, EmployeeCode = "E006", FirstName = "Maria",LastName="Garcia", DepartmentId= 1}
            };
        }
    }
}