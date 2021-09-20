using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Moq;

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

        [TestMethod()]
        public void IsIpAddressActive_TestFalse()
        {
            var IpAddressTest = "192.0.0.168";
            var expected = false;
            var IpAddressClass = new IpAddress();

            var actual = IpAddress.IsIpAddressActive(IpAddressTest);

            Assert.AreNotEqual(expected, actual);
        }
    }
}