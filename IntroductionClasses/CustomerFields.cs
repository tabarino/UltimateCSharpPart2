using System;
using System.Collections.Generic;

namespace IntroductionClasses
{
    public class CustomerFields
    {
        public int Id;
        public string Name;
        public readonly List<OrderFields> Orders = new List<OrderFields>();

        public CustomerFields(int id)
        {
            this.Id = id;
        }

        // this(id) calls the constructor with id and this one calls the main constructor
        public CustomerFields(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // We cannot initialize the Orders again here, because it is readonly
            //Orders = new List<OrderFields>();
        }
    }

    public class OrderFields
    {
        public OrderFields()
        {
        }
    }
}
