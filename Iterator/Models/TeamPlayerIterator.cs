using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Models
{
    public class TeamPlayerIterator : IPlayerIterator
    {
        private readonly Team _team;

        private int _currentIndex;

        public TeamPlayerIterator(Team team)
        {
            _team = team;
        }

        public void First()
        {
            _currentIndex = 0;
        }

        public void Next()
        {
            _currentIndex++;
        }

        public bool IsDone()
        {
            return _currentIndex >= _team.Players.Length;
        }

        public Player Current()
        {
            return _team.Players[_currentIndex];
        }
    }
}
