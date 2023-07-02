using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Drinks:Menu
    {
        
        
        public Drinks (string name, string Description, double cost) : base(name, Description, cost)
        {
            
        }
        public void Check_hot_or_cold(bool X)
        {
            if (X == true)
            {
                Console.WriteLine("The drink is hot");
            }
            else
            {
                Console.WriteLine("The drink is cold");
            }
        }
        
    }
}
