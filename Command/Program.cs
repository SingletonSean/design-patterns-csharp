using Command.Commands;
using Command.Models;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                FirstName = "Singleton",
                LastName = "Sean"
            };
            CommandHistory commandHistory = new CommandHistory();

            App app = new App(
                new ChangeFirstNameCommand(person, commandHistory),
                new ChangeLastNameCommand(person, commandHistory),
                new UndoCommand(commandHistory));

            app.Run();
        }
    }
}
