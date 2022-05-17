using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Models
{
    public class LeaguePlayerIterator : IPlayerIterator
    {
        private readonly League _league;

        private int _currentTeamIndex;
        private TeamPlayerIterator _currentTeamPlayerIterator;

        public LeaguePlayerIterator(League league)
        {
            _league = league;
        }

        public void First()
        {
            _currentTeamIndex = 0;

            if(_currentTeamIndex < _league.Teams.Length)
            {
                _currentTeamPlayerIterator = new TeamPlayerIterator(_league.Teams[_currentTeamIndex]);
            }
        }

        public void Next()
        {
            if(_currentTeamPlayerIterator == null)
            {
                return;
            }

            _currentTeamPlayerIterator.Next();

            if(!_currentTeamPlayerIterator.IsDone())
            {
                return;
            }

            _currentTeamIndex++;

            if (_currentTeamIndex < _league.Teams.Length)
            {
                _currentTeamPlayerIterator = new TeamPlayerIterator(_league.Teams[_currentTeamIndex]);
            }
        }

        public bool IsDone()
        {
            return _currentTeamPlayerIterator == null || _currentTeamPlayerIterator.IsDone();
        }

        public Player Current()
        {
            return _currentTeamPlayerIterator.Current();
        }
    }
}
