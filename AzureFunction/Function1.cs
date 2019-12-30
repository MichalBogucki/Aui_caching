using DbAccess;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Aui.Api
{
    public static class Function1
    {
        [FunctionName("GetAllEuCustomers")]
        public static async Task<HttpResponseMessage> GetAllEuCustomers([HttpTrigger(AuthorizationLevel.Function, "get", Route = "GetAllEuCustomers")]HttpRequestMessage req, TraceWriter log)
        {
            var dbAccess = new Class1(isEu:true);
            var customers = dbAccess.GetAllCustomers();
            var json = JsonConvert.SerializeObject(customers);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

        }

        [FunctionName("GetAllEuCustomerById")]
        public static async Task<HttpResponseMessage> GetAllEuCustomerById([HttpTrigger(AuthorizationLevel.Function, "get", Route = "GetAllEuCustomerById/{id}")]HttpRequestMessage req, string id, TraceWriter log)
        {


            var dbAccess = new Class1(isEu: true);

            var custId = int.Parse(id);
            var customer = dbAccess.GetCustomerById(custId);
            var json = JsonConvert.SerializeObject(customer);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

        }

        [FunctionName("GetAllBrasilCustomers")]
        public static async Task<HttpResponseMessage> GetAllBrasilCustomers([HttpTrigger(AuthorizationLevel.Function, "get", Route = "GetAllBrasilCustomers")]HttpRequestMessage req, TraceWriter log)
        {
            var dbAccess = new Class1(isEu: false);
            var customers = dbAccess.GetAllCustomers();
            var json = JsonConvert.SerializeObject(customers);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

        }

        [FunctionName("GetAllBrasilCustomerById")]
        public static async Task<HttpResponseMessage> GetAllBrasilCustomerById([HttpTrigger(AuthorizationLevel.Function, "get", Route = "GetAllBrasilCustomerById/{id}")]HttpRequestMessage req, string id, TraceWriter log)
        {


            var dbAccess = new Class1(isEu: false);
            var custId = int.Parse(id);
            var customer = dbAccess.GetCustomerById(custId);
            var json = JsonConvert.SerializeObject(customer);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }
    }
}