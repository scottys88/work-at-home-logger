using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class User
    {
        public User()
        {

        }
        public User(int userId)
        {
            UserId = userId;
            IpAddresses = new List<IpAddressDetail>();
        }

        public int UserId { get; private set; }
        public string Name { get; set; }
        public List<IpAddressDetail> IpAddresses { get; set; }

    }
}
