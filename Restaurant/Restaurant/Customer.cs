using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Customer:User
    {
        public int review;

        
        public Customer(string username, int password,int review):base(username,password)
        {
            if(review<10 && review > 0)
            {
                this.review = review ;
            }
            else
            {
                review = 0;
            }
        }
        public void DisplayRate()
        {
            Console.WriteLine("The rating for our dear customer {0} is {1}",Username,review);
        }
    }
}
