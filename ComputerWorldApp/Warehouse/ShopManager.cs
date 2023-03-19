using ComputerWorldApp.Shop.Orders;
using ComputerWorldApp.Shop.Supplier;
using System;

namespace ComputerWorldApp.Shop
{
    class ShopManager 
    {
        private Orders.Orders _orders;

        private ISupplier _supplier;

        public ShopManager (ISupplier supplier)
        {
            _supplier = supplier;

            _orders = new Orders.Orders();
        }

        public int OrderComputer(string json)
        {
            Computer computer = _supplier.Create(json);

            return AddNewOrder(computer);
        }

        public int OrderComputer()
        {
            Computer computer = _supplier.Create();

            return AddNewOrder(computer);
        }

        private int AddNewOrder(Computer computer)
        {
            Orders.Order order = new Order(computer);
            _orders.Add(order);

            return order.GetID();
        }

        public Computer PickUpComputer(int orderID)
        {
            Orders.Order order = _orders.Find(orderID);
            
            if (order == null)
            {
                return null;
            }

            return order.GetProduct();
        }

        public bool Pay(int orderID)
        {
            /* pay */

            return true;
        }
    }
}
