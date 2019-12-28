using System.Collections.Generic;
using System.Linq;

namespace DbAccess
{
    public class Class1
    {
        private readonly string conn = "metadata=res://*/sampleDbEntities.csdl|res://*/sampleDbEntities.ssdl|res://*/sampleDbEntities.msl;provider=System.Data.SqlClient;provider connection string=';data source=tcp:aui2019.database.windows.net,1433;Initial Catalog=sampleDb;Persist Security Info=False;User ID=sql-admin;Password=FitAdm1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;App=EntityFramework;'";

        public List<Customer> GetAllCustomers()
        {
            using (var ctx = new sampleDbEntities(conn))
            {
                var customers = ctx.Customers.Where(x => x.Id > -1).ToList();
                return customers;
            }
        }
        public List<Customer> GetCustomerById(int id)
        {
            using (var ctx = new sampleDbEntities(conn))
            {
                var customers = ctx.Customers.Where(x => x.Id == id).ToList();
                return customers;
            }
        }
    }
}
