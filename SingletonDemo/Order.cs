using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
    }
}
