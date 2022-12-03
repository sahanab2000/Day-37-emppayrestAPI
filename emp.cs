using System.Net;
using Newtonsoft.Json;
using System;
using RestSharp;
using System.Collections.Generic;

namespace EmployeePayrollJson
{
   public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
    }
}