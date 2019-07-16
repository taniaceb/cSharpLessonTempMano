using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_train.Class_lesson9
{
    class Preke
    {
        private string _name;
        private double _price;
        private int _quantity;

        public Preke(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }


        public string AddNewProduct()
        {
            string name = _name;
            return name;
        }

        public double ChangeProductPrice()
        {
            double price = _price + 0.02;
            return price;
        }

        public int ChangeProductQuantity()
        {
            int quantity = _quantity;
            return quantity++;
        }


    }
}
