
using DbAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllCustomers()
        {
            var dbAccess = new Class1();
            var a = dbAccess.GetAllCustomers();
            var b = dbAccess.GetCustomerById(10);
            var z = "";

            Console.WriteLine(z);
        }
    }
}
