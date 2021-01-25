using System;
using System.Collections.Generic;

namespace IntroductionClasses
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;


        public Customer()
        {
            Orders = new List<Order>();
        }

        // The this() here calls the main constructor
        public Customer(int id) : this()
        {
            this.Id = id;
        }

        // this(id) calls the constructor with id and this one calls the main constructor
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }

    public class Order
    {
        public Order()
        {
        }
    }
}
