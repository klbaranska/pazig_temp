using ComputerWorldApp.Shop.Supplier;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerWorldApp.Shop.Orders
{
    public class Order
    {
        private static int _actualOrderID;

        private int _orderID;
        private Computer _product;

        public Order(Computer product)
        {
            _product = product;

            _orderID = _actualOrderID;
            _actualOrderID++;
        }

        public int GetID()
        {
            return _orderID;
        }

        public Computer GetProduct()
        {
            return _product;
        }

        public virtual double GetPrice()
        {
            return _product.GetPrice();
        }
    }
}