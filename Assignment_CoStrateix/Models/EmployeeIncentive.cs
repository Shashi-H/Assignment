using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_CoStrateix.Models
{
    public class EmployeeIncentive
    {
        public int EmployeeIncentiveId { get; set; }
        public int EmployeeId { get; set; }
        public string IncentiveMonth { get; set; }
        public int IncentiveYear { get; set; }
        public int Incentive { get; set; }

        public static List<EmployeeIncentive> GetAllIncentive()
        {
            return new List<EmployeeIncentive>() {
                new EmployeeIncentive { EmployeeIncentiveId = 1, EmployeeId = 1, IncentiveMonth = "Jan", IncentiveYear = 2020, Incentive = 2000},
                new EmployeeIncentive { EmployeeIncentiveId = 2, EmployeeId = 2, IncentiveMonth = "Jan", IncentiveYear = 2020, Incentive = 2000},
                new EmployeeIncentive { EmployeeIncentiveId = 3, EmployeeId = 3, IncentiveMonth = "Jan", IncentiveYear = 2020, Incentive = 1500},
                new EmployeeIncentive { EmployeeIncentiveId = 4, EmployeeId = 5, IncentiveMonth = "Jan", IncentiveYear = 2020, Incentive = 1600},
                new EmployeeIncentive { EmployeeIncentiveId = 5, EmployeeId = 1, IncentiveMonth = "Feb", IncentiveYear = 2020, Incentive = 1500},
                new EmployeeIncentive { EmployeeIncentiveId = 6, EmployeeId = 2, IncentiveMonth = "Feb", IncentiveYear = 2020, Incentive = 2500},
                new EmployeeIncentive { EmployeeIncentiveId = 7, EmployeeId = 5, IncentiveMonth = "Feb", IncentiveYear = 2020, Incentive = 1000},
                new EmployeeIncentive { EmployeeIncentiveId = 8, EmployeeId = 1, IncentiveMonth = "Mar", IncentiveYear = 2020, Incentive = 3000},
                new EmployeeIncentive { EmployeeIncentiveId = 9, EmployeeId = 2, IncentiveMonth = "Mar", IncentiveYear = 2020, Incentive = 3000}

            };
        }
    }
}