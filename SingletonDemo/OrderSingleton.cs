using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public class OrderSingleton
    {
        private static OrderSingleton obj;

        private OrderSingleton()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public static OrderSingleton GetInstance()
        {
            if (obj == null) obj = new OrderSingleton();
            return obj;
        }
    }
}
