using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models.AvailableDashboardLocationStrategies
{
    public class BreadthFirstAvailableDashboardLocationStrategy : IAvailableDashboardLocationStrategy
    {
        public DashboardLocation? Find(DashboardLocation startLocation, Dashboard dashboard)
        {
            HashSet<DashboardLocation> searchedLocations = new HashSet<DashboardLocation>();
            Queue<DashboardLocation> locationsToSearch = new Queue<DashboardLocation>();

            locationsToSearch.Enqueue(startLocation);
            searchedLocations.Add(startLocation);

            while(locationsToSearch.Count > 0)
            {
                DashboardLocation currentLocation = locationsToSearch.Dequeue();

                if(dashboard.IsWithinBounds(currentLocation.X, currentLocation.Y) && !dashboard.HasItem(currentLocation))
                {
                    return currentLocation;
                }

                IEnumerable<DashboardLocation> surroundingLocations = new List<DashboardLocation>
                {
                    currentLocation.Add(0, -1),
                    currentLocation.Add(1, 0),
                    currentLocation.Add(0, 1),
                    currentLocation.Add(-1, 0),
                };

                foreach (DashboardLocation nextLocation in surroundingLocations)
                {
                    if(dashboard.IsWithinBounds(nextLocation.X, nextLocation.Y) && !searchedLocations.Contains(nextLocation))
                    {
                        locationsToSearch.Enqueue(nextLocation);
                        searchedLocations.Add(nextLocation);
                    }
                }
            }

            return null;
        }
    }
}
