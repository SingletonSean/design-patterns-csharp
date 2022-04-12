using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public class Dashboard
    {
        private readonly int[,] _dashboardItems;
        private readonly int _width;
        private readonly int _height;

        public Dashboard(int width, int height)
        {
            _dashboardItems = new int[width, height];
            _width = width;
            _height = height;
        }

        public void AddItem(int value, DashboardLocation location)
        {
            if (location.X < 0 || location.X >= _width) 
                throw new ArgumentException("Width must be positive and less than width.", nameof(location));
            if (location.Y < 0 || location.Y >= _height) 
                throw new ArgumentException("Height must be positive and less than height.", nameof(location));
            if (value <= 0 || value >= 10 ) 
                throw new ArgumentException("Value must be single digit number and greater than zero.", nameof(value));

            _dashboardItems[location.X, location.Y] = value;
        }

        public bool HasItem(DashboardLocation location)
        {
            return _dashboardItems[location.X, location.Y] != 0;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    int currentItem = _dashboardItems[x, y];

                    stringBuilder.Append(currentItem);
                    stringBuilder.Append(" ");
                }

                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}
