using EmployeePayrollJson
using System.Net;
using Newtonsoft.Json;
using System;
using RestSharp;
using System.Collections.Generic;

namespace EmployeePayrollJson
{
  public class UC3AddMultipleEMP
    {
        RestClient restClient = new RestClient("http://localhost:4000");
        
        public void AddMultipleEmployee()
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee { Name = "AAAA", Salary = "7000" });
            employee.Add(new Employee { Name = "LLLL", Salary = "8000" });
            employee.Add(new Employee { Name = "BBBB", Salary = "9000" });
            employee.Add(new Employee { Name = "VVVV", Salary = "10000" });

            foreach(Employee emp in employee)
            {
                RestRequest rq = new RestRequest("/employee", Method.POST);
                JObject jb = new JObject();
                jb.Add("name", emp.Name);
                jb.Add("salary", emp.Salary);
                rq.AddParameter("application/json", jb, ParameterType.RequestBody);
                IRestResponse rr=restClient.Post(rq);
            }
        }

    }
}