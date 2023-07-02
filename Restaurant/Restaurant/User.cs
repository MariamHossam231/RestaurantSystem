using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    abstract class User
    {
        private string username;
        private int password;
        public User() { }

        public User(string username, int password)
        {
            this.username = username;
            this.password = password;
        }
        public string Username{
            get{
                return username;
                }
            set
            {
                username = value;
            }
                               }
        public int Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
