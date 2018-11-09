using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS174Winters.Models
{
    public class Employee
    {
        
            public string firstName { get; set; }
            public string middleName { get; set; }
            public string lastName { get; set; }

            public DateTime birthDate { get; set; }

            public DateTime hireDate { get; set; }

            public Enums.Department department { get; set; }

            public String jobTitle { get; set; }

            public double salary { get; set; }

            public Enums.SalaryType salaryType { get; set; }

            public int ID { get; set; }

            public string availableHours { get; set; }

        }
    }
