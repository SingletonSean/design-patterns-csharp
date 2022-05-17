using System.Collections;

namespace Iterator.Models
{
    public class Team : IPlayerCollection
    {
        public Player[] Players { get; set; }

        public IPlayerIterator CreatePlayerIterator()
        {
            return new TeamPlayerIterator(this);
        }

        public IEnumerator<Player> GetEnumerator()
        {
            return Players.ToList().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
