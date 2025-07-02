using ConsumeWebAPI.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Text;

namespace ConsumeWebAPI.Service
{
    public class ConsumeWebApi
    {
        //base address :  http://localhost:62493/api
        HttpClient client;
        Uri baseAddress = new Uri("http://localhost:62493/api");

        public ConsumeWebApi()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public List<Employee> ConsumeAll()
        {
            List<Employee> employees = new List<Employee>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Employee").Result;

            if (response.IsSuccessStatusCode)
            {
                string receivedData = response.Content.ReadAsStringAsync().Result;

                employees = JsonConvert.DeserializeObject<List<Employee>>(receivedData);
            }
            return employees;
        }

        public Employee GetById(int id)
        {
            Employee emp = new Employee();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Employee/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string receivedData = response.Content.ReadAsStringAsync().Result;
                emp = JsonConvert.DeserializeObject<Employee>(receivedData);
            }

            return emp;
        }

        public bool AddNewEmployee(Employee emp)
        {
            bool status = false;

            string serializedEmployee = JsonConvert.SerializeObject(emp);
            StringContent content = new StringContent(serializedEmployee,Encoding.UTF8,"application/json");

            HttpResponseMessage response = client.PostAsync(client.BaseAddress+"/Employee",content).Result;

            if (response.IsSuccessStatusCode)
            {
                status = true; 
            }

            return status;
        }

        public bool EditEmployee(Employee editedEmp)
        {
            bool status = false;
            //Employee emp = new Employee();
            string serializedEmployee = JsonConvert.SerializeObject(editedEmp);
            StringContent content = new StringContent(serializedEmployee,Encoding.UTF8,"application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress+"/Employee/"+editedEmp.Id,content).Result;
            if (response.IsSuccessStatusCode)
            {
                status = true;
            }

            return status;

        }

        public bool DeleteEmployee(int id)
        {
            bool status = false;

            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress+"/Employee/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                status = true;
            }

            return status;
        }
    }
}