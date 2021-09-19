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
            return user;
        }

    }
}
