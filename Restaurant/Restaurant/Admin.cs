using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Admin:User
    {
        private int workinghours;
        private double salary;
        private int bonushours;
        
        public Admin() { }
        
        public Admin(string username, int password,int workinghours,double salary):base(username,password) {
            this.workinghours = workinghours;
            this.salary = salary;
        }
        public int Workinghours
        {
            get
            {
                return workinghours;
            }
            set
            {
                workinghours = value;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public int Bonushours{

            get
            {
                return bonushours;
            }
            set
            {
                bonushours = value;
            }
        }

        public void Displayworkhours()
        {
            Console.WriteLine("{0} works {1} hours per day",Username, workinghours);
        }
        public void DisplaySalary()
        {
            Console.WriteLine("{0} his salary is {1} per month  ", Username, salary);
        }
        public double Calctotalsalary()
        {
            return salary + 50 * bonushours;
        }
    }
}
