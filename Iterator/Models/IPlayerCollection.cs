using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Models
{
    public interface IPlayerCollection : IEnumerable<Player>
    {
        IPlayerIterator CreatePlayerIterator();
    }
}
