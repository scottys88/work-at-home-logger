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
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public String IpAddresses { get; set; }

    }
}
