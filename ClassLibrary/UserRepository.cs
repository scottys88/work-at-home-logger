using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class UserRepository
    {
        public UserRepository()
        {
            
        }

        public User Retrieve(int userId)
        {
            User user = new User(userId);
            if(userId == 1)
            {
                user.Name = "Scott";
                var homeIp = "2001:8003:a8bc:ad00:b1a0:d606:a094:5dda";
                var homeIpDetail = new IpAddressDetail(homeIp, "homeIp");
                

            }
            return user;
        }

    }
}
