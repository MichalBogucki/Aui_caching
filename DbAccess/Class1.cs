using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private Random random;

        public Class1()
        {
            _isEu = true;
            _conn = GetConn(_isEu);

        }
        public Class1(bool isEu)
        {
            _isEu = isEu;
            _conn = GetConn(_isEu);
        }

        public List<Customer> GetAllCustomers()
        {
            using (var ctx = new sampleDbEntities(_conn))
            {
                var customers = ctx.Customers.Where(x => x.Id > -1).ToList();
                
                return customers;
            }
        }

        public List<AllTablesJoined> GetJoinedTablesByCustomers(int amount)
        {
            using (var ctx = new sampleDbEntities(_conn))
            {
                var allTablesJoined = (from cu in ctx.Customers
                        join ord in ctx.Orders on cu.Id equals ord.CustomerId
                        join oi in ctx.OrderItems on ord.Id equals oi.OrderId
                        join pro in ctx.Products on oi.ProductId equals pro.Id
                        join sup in ctx.Suppliers on pro.SupplierId equals sup.Id
                        where cu.Id <= amount
                        select new AllTablesJoined (){ Customer = cu, Order = ord, OrderItem = oi, Product = pro, Supplier = sup})
                    .ToList();

                return allTablesJoined;
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


        public void FillMoreColumnsWithData()
        {
            random = new Random();

            FillCustomersWithData();
            FillOrdersWithData();
            FillProductsWithData();
            FillSuppliersWithData();
            FillOrderItemsWithData();
        }

        private void FillSuppliersWithData()
        {
            using (var ctx = new sampleDbEntities(_conn))
            {
                var Suppliers = ctx.Suppliers.Where(x => x.Id > -1).ToList();
                foreach (var supplier in Suppliers)
                {
                    supplier.moreColumn1 = RandomString(50);
                    supplier.moreColumn2 = RandomString(50);
                    supplier.moreColumn3 = RandomString(50);
                    supplier.moreColumn4 = RandomString(50);
                    supplier.moreColumn5 = RandomString(50);
                    supplier.moreColumn6 = RandomString(50);
                    supplier.moreColumn7 = RandomString(50);
                    supplier.moreColumn8 = RandomString(50);
                    supplier.moreColumn9 = RandomString(50);
                    supplier.moreColumn10 = RandomString(50);
                    supplier.moreColumn11 = RandomString(50);
                    supplier.moreColumn12 = RandomString(50);
                    supplier.moreColumn13 = RandomString(50);
                    supplier.moreColumn14 = RandomString(50);
                    supplier.moreColumn15 = RandomString(50);
                    supplier.moreColumn16 = RandomString(50);
                    supplier.moreColumn17 = RandomString(50);
                    supplier.moreColumn18 = RandomString(50);
                    supplier.moreColumn19 = RandomString(50);
                    supplier.moreColumn20 = RandomString(50);
                }

                ctx.SaveChanges();
            }
        }

        private void FillProductsWithData()
        {
            using (var ctx = new sampleDbEntities(_conn))
            {
                var Products = ctx.Products.Where(x => x.Id > -1).ToList();
                foreach (var product in Products)
                {
                    product.moreColumn1 = RandomString(50);
                    product.moreColumn2 = RandomString(50);
                    product.moreColumn3 = RandomString(50);
                    product.moreColumn4 = RandomString(50);
                    product.moreColumn5 = RandomString(50);
                    product.moreColumn6 = RandomString(50);
                    product.moreColumn7 = RandomString(50);
                    product.moreColumn8 = RandomString(50);
                    product.moreColumn9 = RandomString(50);
                    product.moreColumn10 = RandomString(50);
                    product.moreColumn11 = RandomString(50);
                    product.moreColumn12 = RandomString(50);
                    product.moreColumn13 = RandomString(50);
                    product.moreColumn14 = RandomString(50);
                    product.moreColumn15 = RandomString(50);
                    product.moreColumn16 = RandomString(50);
                    product.moreColumn17 = RandomString(50);
                    product.moreColumn18 = RandomString(50);
                    product.moreColumn19 = RandomString(50);
                    product.moreColumn20 = RandomString(50);
                }

                ctx.SaveChanges();
            }
        }

        private void FillOrderItemsWithData()
        {
            using (var ctx = new sampleDbEntities(_conn))
            {
                var OrderItems = ctx.OrderItems.Where(x => x.Id > 302).ToList();
                foreach (var orderItem in OrderItems)
                {
                    orderItem.moreColumn1 = RandomString(50);
                    orderItem.moreColumn2 = RandomString(50);
                    orderItem.moreColumn3 = RandomString(50);
                    orderItem.moreColumn4 = RandomString(50);
                    orderItem.moreColumn5 = RandomString(50);
                    orderItem.moreColumn6 = RandomString(50);
                    orderItem.moreColumn7 = RandomString(50);
                    orderItem.moreColumn8 = RandomString(50);
                    orderItem.moreColumn9 = RandomString(50);
                    orderItem.moreColumn10 = RandomString(50);
                    orderItem.moreColumn11 = RandomString(50);
                    orderItem.moreColumn12 = RandomString(50);
                    orderItem.moreColumn13 = RandomString(50);
                    orderItem.moreColumn14 = RandomString(50);
                    orderItem.moreColumn15 = RandomString(50);
                    orderItem.moreColumn16 = RandomString(50);
                    orderItem.moreColumn17 = RandomString(50);
                    orderItem.moreColumn18 = RandomString(50);
                    orderItem.moreColumn19 = RandomString(50);
                    orderItem.moreColumn20 = RandomString(50);

                    ctx.SaveChanges();
                }

            }
        }

        private void FillOrdersWithData()
        {
            using (var ctx = new sampleDbEntities(_conn))
            {
                var Orders = ctx.Orders.Where(x => x.Id > -1).ToList();
                foreach (var order in Orders)
                {
                    order.moreColumn1 = RandomString(50);
                    order.moreColumn2 = RandomString(50);
                    order.moreColumn3 = RandomString(50);
                    order.moreColumn4 = RandomString(50);
                    order.moreColumn5 = RandomString(50);
                    order.moreColumn6 = RandomString(50);
                    order.moreColumn7 = RandomString(50);
                    order.moreColumn8 = RandomString(50);
                    order.moreColumn9 = RandomString(50);
                    order.moreColumn10 = RandomString(50);
                    order.moreColumn11 = RandomString(50);
                    order.moreColumn12 = RandomString(50);
                    order.moreColumn13 = RandomString(50);
                    order.moreColumn14 = RandomString(50);
                    order.moreColumn15 = RandomString(50);
                    order.moreColumn16 = RandomString(50);
                    order.moreColumn17 = RandomString(50);
                    order.moreColumn18 = RandomString(50);
                    order.moreColumn19 = RandomString(50);
                    order.moreColumn20 = RandomString(50);
                }

                ctx.SaveChanges();
            }
        }

        private void FillCustomersWithData()
        {
            using (var ctx = new sampleDbEntities(_conn))
            {
                var Customers = ctx.Customers.Where(x => x.Id > -1).ToList();
                foreach (var customer in Customers)
                {
                    customer.moreColumn1 = RandomString(50);
                    customer.moreColumn2 = RandomString(50);
                    customer.moreColumn3 = RandomString(50);
                    customer.moreColumn4 = RandomString(50);
                    customer.moreColumn5 = RandomString(50);
                    customer.moreColumn6 = RandomString(50);
                    customer.moreColumn7 = RandomString(50);
                    customer.moreColumn8 = RandomString(50);
                    customer.moreColumn9 = RandomString(50);
                    customer.moreColumn10 = RandomString(50);
                    customer.moreColumn11 = RandomString(50);
                    customer.moreColumn12 = RandomString(50);
                    customer.moreColumn13 = RandomString(50);
                    customer.moreColumn14 = RandomString(50);
                    customer.moreColumn15 = RandomString(50);
                    customer.moreColumn16 = RandomString(50);
                    customer.moreColumn17 = RandomString(50);
                    customer.moreColumn18 = RandomString(50);
                    customer.moreColumn19 = RandomString(50);
                    customer.moreColumn20 = RandomString(50);
                }

                ctx.SaveChanges();
            }
        }


        private string GetConn(bool isEu)
        {
            Dictionary<bool, string> connDict = new Dictionary<bool, string>
            {
                {true, _connEu},
                {false, _connBrasil}
            };

            return connDict[isEu];
        }

        private string RandomString(int size, bool lowerCase = false)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

    }

    public class AllTablesJoined
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
        public OrderItem OrderItem { get; set; }
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}
