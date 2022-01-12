using Command.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class ChangeFirstNameCommand : ICommand, IUndoCommand
    {
        private readonly Person _person;
        private readonly CommandHistory _commandHistory;

        private string _previousFirstName;

        public ChangeFirstNameCommand(Person person, CommandHistory commandHistory)
        {
            _person = person;
            _commandHistory = commandHistory;
        }

        public void Execute()
        {
            _previousFirstName = _person.FirstName;

            _person.FirstName = new Bogus.Faker().Person.FirstName;
            Console.WriteLine(_person);

            _commandHistory.Push(Clone());
        }

        public void Undo()
        {
            if(_previousFirstName != null)
            {
                _person.FirstName = _previousFirstName;
            }

            Console.WriteLine(_person);
        }

        private ChangeFirstNameCommand Clone()
        {
            ChangeFirstNameCommand changeFirstNameCommand = new ChangeFirstNameCommand(_person, _commandHistory);

            changeFirstNameCommand._previousFirstName = _previousFirstName;

            return changeFirstNameCommand;
        }
    }
}
