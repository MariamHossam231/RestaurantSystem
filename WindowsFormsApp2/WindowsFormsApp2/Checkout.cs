using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Checkout
    {
        double totalPrice = 0;
        private string promocode;

        public Checkout() { }
        public Checkout(double totalPrice,string promocode) {

            this.totalPrice = totalPrice;
            this.promocode = promocode;
        }
        public string Promocode
        {
            get
            {
                return promocode;
            }
            set
            {
                promocode = value;
            }
        }
        public double CalcTotal(double X)
        {
            totalPrice = totalPrice + X;
            return totalPrice;
        }

       
        public double Discount(string promocode)
        {
            double disc = totalPrice * 0.15;
            double y = totalPrice - disc;
            return y;
        } 
        public void DisplayTotal() {
            Console.WriteLine("Total bill is : {0}", totalPrice);
        }
    }
}
