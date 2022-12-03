using EmployeePayrollJson
using System.Net;
using Newtonsoft.Json;
using System;
using RestSharp;
using System.Collections.Generic;

namespace EmployeePayrollJson
{
  public class UC5DeleteEMp
    {
        RestClient restClient = new RestClient("http://localhost:4000");
        
        public void DeleteEmployee()
        {
            RestRequest rq = new RestRequest("/employee/108", Method.DELETE);
            restClient.Delete(rq);
        }

    }
}