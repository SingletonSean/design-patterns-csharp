using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Models
{
    public interface IPlayerIterator
    {
        void First();
        void Next();
        bool IsDone();
        Player Current();
    }
}
