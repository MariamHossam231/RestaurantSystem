using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Ahmed", 1290, 9);
            Customer customer2 = new Customer("zeyad", 1390, 8);
            Admin a1 = new Admin("omar", 1234, 16, 3500);
            Admin a2 = new Admin("Mariam", 5555, 23, 1290);
            Admin a3 = new Admin("Abasiery", 1111, 4, 9000);


            User[] users = new User[5];
            users[0] = customer1;
            users[1] = customer2;
            users[2] = a1;
            users[3] = a2;
            users[4] = a3;

            foreach(var currentuser in users)
            {
                if (currentuser is Admin)
                {
                    Admin admin = (Admin)currentuser;
                    admin.DisplaySalary();
                }
                else if (currentuser is Customer)
                {
                    Customer customer = (Customer)currentuser;
                    customer.DisplayRate();
                }

            }

            
        }
    }
}
