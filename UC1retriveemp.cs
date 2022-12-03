using System.Net;
using Newtonsoft.Json;
using System;
using RestSharp;
using System.Collections.Generic;

namespace EmployeePayrollJson
{
  public class UC1RetrieveEMP
    {
        RestClient restClient = new RestClient("http://localhost:4000");

        public IRestResponse GetEmployeeList()
        {
            RestRequest restRequest = new RestRequest("/employee", Method.GET);

            IRestResponse restResponse = restClient.Execute(restRequest);
            return restResponse;
        }

        public void Display()
        {
            IRestResponse response = GetEmployeeList();
            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(response.Content);
            if (3.Equals(employees.Count))
            {
                Console.WriteLine("Pass");
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("Fail");
                Console.WriteLine("-----------------------------------");
            }
            foreach (Employee emp in employees)
            {
                Console.WriteLine("ID:" + emp.Id);
                Console.WriteLine("Name:" + emp.Name);
                Console.WriteLine("Salary:" + emp.Salary);
                Console.WriteLine();
            }
        }
    }
}