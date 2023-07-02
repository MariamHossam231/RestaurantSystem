using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Drinks:Menu
    {
        bool hot;
        bool cold;

        public Drinks (string name, string Description, double cost,bool hot,bool cold) : base(name, Description, cost)
        {
            this.hot = hot;
            this.cold = cold;
        }
        
    }
}
