using Strategy.Models;
using System;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dashboard dashboard = new Dashboard(5, 5);

            dashboard.AddItem(1, new DashboardLocation(1, 4));
            dashboard.AddItem(2, new DashboardLocation(1, 4));
            dashboard.AddItem(3, new DashboardLocation(1, 4));

            Console.WriteLine(dashboard);

            Console.ReadKey();
        }
    }
}
