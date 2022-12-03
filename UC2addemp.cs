using EmployeePayrollJson;
using System.Net;
using Newtonsoft.Json;
using System;
using RestSharp;
using System.Collections.Generic;

namespace EmployeePayrollJson
{
  public class UC2ADDEmployee
    {
        RestClient restClient = new RestClient("http://localhost:4000");

        public void AddEmployee()
        {
            RestRequest restRequest = new RestRequest("/employee", Method.POST);
            JObject jb = new JObject();
            jb.Add("name", "John");
            jb.Add("salary", 6000);
            restRequest.AddParameter("application/json", jb, ParameterType.RequestBody);

            IRestResponse restResponse = restClient.Post(restRequest);
        }
    }
}