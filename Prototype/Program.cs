using Prototype.Models;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile profile = new Profile()
            {
                Name = "SingletonSean",
                Email = "test@gmail.com"
            };
            profile.SetDateOfBirth(new DateTime(1990, 1, 1));

            ProfileSettings settings = new ProfileSettings()
            {
                HideEmail = true,
                HideAge = false
            };
            profile.SetSettings(settings);

            DisplayProfile(profile);

            Console.ReadKey();
        }

        private static void DisplayProfile(Profile profile)
        {
            Console.WriteLine("General");
            Console.WriteLine("------------");
            Console.WriteLine($"Name: {profile.Name}");

            if (!profile.HideEmail)
            {
                Console.WriteLine($"Email: {profile.Email}");
            }

            if (!profile.HideAge)
            {
                Console.WriteLine($"Age: {profile.Age}");
            }
        }
    }
}
