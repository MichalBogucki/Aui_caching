using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DbAccess;

namespace FunctionApp1
{
    public static class Function1
    {
        [FunctionName("GetAllCustomers")]
        public static async Task<HttpResponseMessage> GetAllCustomers([HttpTrigger(AuthorizationLevel.Function, "get", Route = "GetAllCustomers")]HttpRequestMessage req, TraceWriter log)
        {


            var dbAccess = new Class1();
            var customers = dbAccess.GetAllCustomers();
            var json = JsonConvert.SerializeObject(customers);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

        }

        [FunctionName("GetAllCustomerById")]
        public static async Task<HttpResponseMessage> GetAllCustomerById([HttpTrigger(AuthorizationLevel.Function, "get", Route = "GetCustomer/{id}")]HttpRequestMessage req, string id, TraceWriter log)
        {


            var dbAccess = new Class1();
            var custId = int.Parse(id);
            var customer = dbAccess.GetCustomerById(custId);
            var json = JsonConvert.SerializeObject(customer);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }

        [FunctionName("Function2")]
        public static async Task<HttpResponseMessage> Function2([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "Function2/name/{name}")]HttpRequestMessage req, string name, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            //Fetching the name from the path parameter in the request URL
            return req.CreateResponse(HttpStatusCode.OK, "Hello " + name);
        }
    }
}
