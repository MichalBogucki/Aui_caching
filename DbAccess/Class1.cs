using System.Collections.Generic;
using System.Linq;

namespace DbAccess
{
    public class Class1
    {
        private string _conn;

        private readonly string _connEu =
            "metadata=res://*/sampleDbEntities.csdl|res://*/sampleDbEntities.ssdl|res://*/sampleDbEntities.msl;provider=System.Data.SqlClient;provider connection string=';data source=" +
            "tcp:aui20192020.database.windows.net,1433;Initial Catalog=sambleDb;Persist Security Info=False;User ID=sql-admin;Password=FitAdm1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;App=EntityFramework;'";

        private readonly string _connBrasil =
            "metadata=res://*/sampleDbEntities.csdl|res://*/sampleDbEntities.ssdl|res://*/sampleDbEntities.msl;provider=System.Data.SqlClient;provider connection string=';data source=" +
            "tcp:auibrasil.database.windows.net,1433;Initial Catalog=sambleDb;Persist Security Info=False;User ID=sql-admin;Password=FitAdm1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;App=EntityFramework;'";

        private bool _isEu;

        public Class1(bool isEu)
        {
            _isEu = isEu;
            _conn = GetConn(isEu);
        }

        public List<Customer> GetAllCustomers()
        {
            using (var ctx = new sampleDbEntities(_conn))
            {
                var customers = ctx.Customers.Where(x => x.Id > -1).ToList();
                return customers;
            }
        }

        public List<Customer> GetCustomerById(int id)
        {
            using (var ctx = new sampleDbEntities(_conn))
            {
                var customers = ctx.Customers.Where(x => x.Id == id).ToList();
                return customers;
            }
        }


        public string GetConn(bool isEu)
        {
            Dictionary<bool, string> connDict = new Dictionary<bool, string>
            {
                {true, _connEu},
                {false, _connBrasil}
            };

            return connDict[isEu];
        }

    }
}
