using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class ChangeLastNameCommand : ICommand, IUndoCommand
    {
        private readonly Person _person;
        private readonly CommandHistory _commandHistory;

        private string _previousLastName;

        public ChangeLastNameCommand(Person person, CommandHistory commandHistory)
        {
            _person = person;
            _commandHistory = commandHistory;
        }

        public void Execute()
        {
            _previousLastName = _person.LastName;

            _person.LastName = new Bogus.Faker().Person.LastName;
            Console.WriteLine(_person);

            _commandHistory.Push(Clone());
        }

        public void Undo()
        {
            if (_previousLastName != null)
            {
                _person.LastName = _previousLastName;
            }

            Console.WriteLine(_person);
        }

        private ChangeLastNameCommand Clone()
        {
            ChangeLastNameCommand changeLastNameCommand = new ChangeLastNameCommand(_person, _commandHistory);

            changeLastNameCommand._previousLastName = _previousLastName;

            return changeLastNameCommand;
        }
    }
}
