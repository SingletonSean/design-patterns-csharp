using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public interface IUndoCommand : ICommand
    {
        void Undo();
    }
}
