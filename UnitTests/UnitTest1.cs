
using DbAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void GetAllCustomers(bool isEu)
        {

            var dbAccess = new Class1(isEu);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var a = dbAccess.GetAllCustomers();
            var b = dbAccess.GetCustomerById(10);
            var c = dbAccess.GetJoinedTablesByCustomers(1);
            var z = "";
            sw.Stop();
            Console.WriteLine($"Elapsed={sw.Elapsed}, isEu={isEu}");
            Console.WriteLine(z);
        }
    }
}
