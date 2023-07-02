using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Customer:User
    {
        int review;
        public Customer(string username, int password,int review):base(username,password)
        {
            this.review = review;
        }
    }
}
