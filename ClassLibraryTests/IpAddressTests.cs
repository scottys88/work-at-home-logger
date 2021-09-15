using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class IpAddressTests
    {
        [TestMethod()]
        public void GetHostNameTest()
        {
            var expected = Dns.GetHostName();

            var actual = IpAddress.GetHostName();

            Assert.AreEqual(expected, actual);
        }
    }
}