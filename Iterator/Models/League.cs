using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Models
{
    public class League : IPlayerCollection
    {
        public Team[] Teams { get; set; }

        public IPlayerIterator CreatePlayerIterator()
        {
            return new LeaguePlayerIterator(this);
        }

        public IEnumerator<Player> GetEnumerator()
        {
            foreach (Team team in Teams)
            {
                foreach (Player player in team)
                {
                    yield return player;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
