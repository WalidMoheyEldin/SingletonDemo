using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Without sington pattern =====");
            Order order = new Order();
            Console.WriteLine(order.Id);
            Order order2 = new Order();
            Console.WriteLine(order2.Id);
            Order order3 = new Order();
            Console.WriteLine(order3.Id);

            Console.WriteLine("\n\n");

            Console.WriteLine("===== Using sington pattern =====");
            OrderSingleton orderSingleton = OrderSingleton.GetInstance();
            Console.WriteLine(orderSingleton.Id);
            OrderSingleton orderSingleton2 = OrderSingleton.GetInstance();
            Console.WriteLine(orderSingleton2.Id);
            OrderSingleton orderSingleton3 = OrderSingleton.GetInstance();
            Console.WriteLine(orderSingleton3.Id);

            Console.ReadKey();
        }
    }
}
