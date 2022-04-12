namespace Strategy.Models
{
    public struct DashboardLocation
    {
        public int X { get; set; }
        public int Y { get; set; }

        public DashboardLocation(int x, int y)
        {
            X = x;
            Y = y;
        }

        public DashboardLocation Add(int x, int y)
        {
            return new DashboardLocation(X + x, Y + y);
        }
    }
}
