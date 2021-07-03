using Flyweight.Models;
using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        private static Random _random = new Random();

        private const int CPU_PURCHASE_COUNT = 10000000; // 1 million

        static void Main(string[] args)
        {
            CpuProductFlyweightFactory cpuProductFactory = new CpuProductFlyweightFactory();
            CpuOrderItemFactory cpuOrderItemFactory = new CpuOrderItemFactory(cpuProductFactory);

            List<Order> orders = new List<Order>();

            for (int i = 0; i < CPU_PURCHASE_COUNT; i++)
            {
                Order order = new Order();

                CpuSeries cpuSeries = GetRandomCpuSeries();
                OrderItem cpu = cpuOrderItemFactory.Create(cpuSeries, 1);
                order.Add(cpu);

                orders.Add(order);
            }

            Console.ReadKey();
        }

        private static CpuSeries GetRandomCpuSeries()
        {
            return (CpuSeries) _random.Next(0, 3);
        }
    }
}
