using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models.AvailableDashboardLocationStrategies
{
    public class DepthFirstAvailableDashboardLocationStrategy : IAvailableDashboardLocationStrategy
    {
        public DashboardLocation? Find(DashboardLocation startLocation, Dashboard dashboard)
        {
            return Find(startLocation, dashboard, new HashSet<DashboardLocation>());
        }

        private DashboardLocation? Find(DashboardLocation startLocation, Dashboard dashboard, HashSet<DashboardLocation> searchedLocations)
        {
            if (searchedLocations.Contains(startLocation))
            {
                return null;
            }

            searchedLocations.Add(startLocation);

            if (!dashboard.IsWithinBounds(startLocation.X, startLocation.Y))
            {
                return null;
            }

            if (!dashboard.HasItem(startLocation))
            {
                return startLocation;
            }

            IEnumerable<DashboardLocation> surroundingLocations = new List<DashboardLocation>
            {
                startLocation.Add(0, -1),
                startLocation.Add(1, 0),
                startLocation.Add(0, 1),
                startLocation.Add(-1, 0),
            };

            foreach (DashboardLocation currentLocation in surroundingLocations)
            {
                DashboardLocation? availableLocation = Find(currentLocation, dashboard, searchedLocations);

                if (availableLocation != null)
                {
                    return availableLocation;
                }
            }

            return null;
        }
    }
}
