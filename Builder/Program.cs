using Builder.FormSubmitters;
using Builder.FormValidators;
using Builder.Models;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormSubmitter formSubmitter = new FormSubmitterBuilder()
                .SkipValidation()
                .WithReceipt()
                .Build();

            Form userForm = PromptUser();

            try
            {
                formSubmitter.Submit(userForm);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        private static Form PromptUser()
        {
            Form form = new Form();

            Console.Write("Enter an email: ");
            form.Email = Console.ReadLine();

            Console.Write("Enter a username: ");
            form.Username = Console.ReadLine();

            Console.Write("Enter your favorite number: ");
            double.TryParse(Console.ReadLine(), out double favoriteNumber);
            form.FavoriteNumber = favoriteNumber;

            return form;
        }
    }
}
