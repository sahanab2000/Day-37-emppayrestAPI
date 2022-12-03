using EmployeePayrollJson
using System.Net;
using Newtonsoft.Json;
using System;
using RestSharp;
using System.Collections.Generic;

namespace EmployeePayrollJson
{
  public class UC4UpdateSalary
    {
        RestClient restClient = new RestClient("http://localhost:4000");
        
        public void UpdateEmployeeSalary()
        {
            RestRequest rq=new RestRequest("/employee/107",Method.PUT);
            JObject jb = new JObject();
            jb.Add("salary", "11000");
            rq.AddOrUpdateParameter("application/json", jb, ParameterType.RequestBody);

            IRestResponse rr=restClient.Put(rq);
        }

    }
}