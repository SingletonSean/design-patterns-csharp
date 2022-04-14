using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models.AvailableDashboardLocationStrategies
{
    public interface IAvailableDashboardLocationStrategy
    {
        DashboardLocation? Find(DashboardLocation startLocation, Dashboard dashboard);
    }
}
