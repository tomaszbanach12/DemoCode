﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime OrderDate {get; set; }

        public Order (Customer customer)
        {
            Customer = customer;
            Items = new List<OrderItem>();
        }
    }
}
