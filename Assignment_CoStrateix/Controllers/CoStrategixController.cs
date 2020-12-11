using Assignment_CoStrateix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_CoStrateix.Controllers
{
    public class CoStrategixController : ApiController
    {
        public string Get()
        {
            
            return "Pass year as the parameter";
        }

        public List<Resulset> Get(int year)
        {            
            List<Resulset> resulsets = new List<Resulset>();
            foreach (Employee employee in Employee.GetAllEmployees())
            {
                IEnumerable<EmployeeIncentive> resultset = EmployeeIncentive.GetAllIncentive()
                            .Where(i => i.IncentiveYear == year && i.EmployeeId == employee.EmployeeId);

                resulsets.Add(new Resulset
                {
                    EmployeeCode = employee.EmployeeCode,
                    FullName = employee.FirstName + " " + employee.LastName,
                    TotalIncentive = resultset.Sum(i => i.Incentive)
                });
            }

            return resulsets;
        }
    }

       
    
}
