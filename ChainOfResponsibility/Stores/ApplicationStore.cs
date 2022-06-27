using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Stores
{
    public class ApplicationStore
    {
        public bool HasExited { get; private set; }

        public void Exit()
        {
            HasExited = true;
        }
    }
}
