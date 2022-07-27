using Mediator.Mediators;
using Mediator.Scripts;

UserMediator userMediator = new UserMediator();

ListUsersScript listUsersScript = new ListUsersScript(userMediator);
NewestUserScript newestUserScript = new NewestUserScript(userMediator);
SignUpScript signUpScript = new SignUpScript(userMediator);

bool hasExited = false;

do
{
    Console.WriteLine("Enter a number corresponding to the following command: ");

    Console.WriteLine("1: Sign up");
    Console.WriteLine("9: Exit");

    ConsoleKey command = Console.ReadKey().Key;

    Console.WriteLine();

    switch (command)
    {
        case ConsoleKey.D1:
            signUpScript.Run();
            break;
        case ConsoleKey.D9:
            hasExited = true;
            break;
        default:
            Console.WriteLine("Invalid command.");
            break;
    }
} while (!hasExited);

listUsersScript.Dispose();
newestUserScript.Dispose();
