using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Admin:User
    {
        int workinghours;
        double salary;
        
        public Admin(string username, int password,int workinghours,double salary):base(username,password) {
            this.workinghours = workinghours;
            this.salary = salary;
        }

        public void Displayworkhours()
        {
            Console.WriteLine("{0} works {1} hours per day",Username, workinghours);
        }
        public void DisplaySalary()
        {
            Console.WriteLine("{0} his salary is {1} per month  ", Username, salary);
        }
    }
}
