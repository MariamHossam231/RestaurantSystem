using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Checkout
    {
        private double totalPrice ;
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
        //
        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
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
        //
    }
}
