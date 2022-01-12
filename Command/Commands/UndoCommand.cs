using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class UndoCommand : ICommand
    {
        private readonly CommandHistory _commandHistory;

        public UndoCommand(CommandHistory commandHistory)
        {
            _commandHistory = commandHistory;
        }

        public void Execute()
        {
            IUndoCommand command = _commandHistory.Pop();
            command?.Undo();
        }
    }
}
