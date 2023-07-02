using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    abstract class Menu
    {
        string name;
        string Description;
        double cost;
        
        public Menu()
        {
        }
        public Menu(string name,string Description,double cost) {

            this.name = name;
            this.Description = Description;
            this.cost = cost;
        }
    }
}
