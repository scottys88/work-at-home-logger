using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class IpAddressDetail
    {
        public IpAddressDetail()
        {

        }
        public IpAddressDetail(string ipAddress, string name)
        {
            IpAddress = ipAddress;
            Name = name;
        }

        public string IpAddress { get; set; }
        public string Name { get; set; }
    }
}
