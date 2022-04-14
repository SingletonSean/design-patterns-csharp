using Strategy.Models;
using Strategy.Models.AvailableDashboardLocationStrategies;
using System;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dashboard dashboard = new Dashboard(5, 5, new BreadthFirstAvailableDashboardLocationStrategy());

            dashboard.AddItem(1, new DashboardLocation(2, 2));
            dashboard.AddItem(2, new DashboardLocation(2, 2));
            dashboard.AddItem(3, new DashboardLocation(2, 2));
            dashboard.AddItem(4, new DashboardLocation(2, 2));
            dashboard.AddItem(5, new DashboardLocation(2, 2));
            dashboard.AddItem(6, new DashboardLocation(2, 2));

            Console.WriteLine(dashboard);

            Console.ReadKey();
        }
    }
}
