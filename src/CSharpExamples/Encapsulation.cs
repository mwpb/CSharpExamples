using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials
{
    public class Encapsulation
    {
        public class Order
        {
            public string OrderNumber { get; }
            public Order(string orderNumber)
            {
                OrderNumber = orderNumber;
            }
        }
        public class Customer
        {
            public Customer(string name)
            {
                Name = name;
            }
            public string Name { get; }
            private List<Order> _orders { get; } = new List<Order>();
            private ReadOnlyCollection<Order> _orderView;
            public ReadOnlyCollection<Order> Orders
            {
                get
                {
                    if(_orderView == null)
                    {
                        _orderView = new ReadOnlyCollection<Order>(_orders);
                    }
                    return _orderView;
                    // at the ienumerable part of encapsulation
                }
            }
        }
    }
}
