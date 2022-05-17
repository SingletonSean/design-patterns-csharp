namespace Iterator.Models
{
    public class Player
    {
        public string FirstName { get; }
        public string LastName { get; }
        public double PointsPerGame { get; }

        public Player(string firstName, string lastName, double pointsPerGame)
        {
            FirstName = firstName;
            LastName = lastName;
            PointsPerGame = pointsPerGame;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {PointsPerGame} PPG";
        }
    }
}
