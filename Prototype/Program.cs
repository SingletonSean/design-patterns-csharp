using Prototype.Models;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup profile.
            Profile profile = new Profile()
            {
                Name = "SingletonSean",
                Email = "test@gmail.com"
            };
            profile.SetDateOfBirth(new DateTime(1990, 1, 1));
            profile.SetSettings(new ProfileSettings()
            {
                HideEmail = true,
                HideAge = false
            });

            DisplayProfile(profile);

            Console.ReadKey();

            // Edit profile.
            Console.Write("\n\n\n");
            Console.WriteLine("Edit Profile");
            Console.WriteLine("------------");

            Profile editProfile = profile.Clone();

            Console.Write("Name: ");
            editProfile.Name = Console.ReadLine();

            Console.Write("Email: ");
            editProfile.Email = Console.ReadLine();

            Console.Write("Private Profile (1 = yes): ");
            editProfile.IsPrivate = Console.ReadLine() == "1";

            Console.Write("Hide Email (1 = yes): ");
            editProfile.HideEmail = Console.ReadLine() == "1";

            Console.Write("Hide Age (1 = yes): ");
            editProfile.HideAge = Console.ReadLine() == "1";

            Console.Write("\n\n\n");
            DisplayProfile(editProfile);

            Console.WriteLine();
            Console.Write("Would you like to save these changes? (1 = yes)");
            bool saveChanges = Console.ReadLine() == "1";

            Console.WriteLine();

            if (saveChanges)
            {
                profile = editProfile;
                Console.WriteLine("Successfully saved profile.");
            }
            else
            {
                Console.WriteLine("Undoing profile changes...");
            }

            Console.Write("\n\n\n");

            DisplayProfile(profile);

            Console.ReadKey();

            // Create profile from prototype.
            ProfileSettings defaultSettingsPrototype = new ProfileSettings()
            {
                IsPrivate = false,
                HideAge = true,
                HideEmail = true
            };
            ProfileSettings secureSettingsPrototype = new ProfileSettings()
            {
                IsPrivate = true,
                HideAge = true,
                HideEmail = true
            };
            ProfileSettingsPrototypeRegistry settingsPrototypeRegistry = new ProfileSettingsPrototypeRegistry(
                defaultSettingsPrototype, secureSettingsPrototype);

            Console.Write("\n\n\n");
            Console.WriteLine("Create Profile");
            Console.WriteLine("------------");

            Profile newProfile = new Profile();

            Console.Write("Name: ");
            newProfile.Name = Console.ReadLine();

            Console.Write("Email: ");
            newProfile.Email = Console.ReadLine();

            Console.Write("Settings (1 = default, 2 = secure, other = custom): ");
            switch(Console.ReadLine())
            {
                case "1":
                    // Get default settings prototype.
                    newProfile.SetSettings(settingsPrototypeRegistry.CreateDefaultProfileSettings());
                    break;
                case "2":
                    // Get secure settings prototype.
                    newProfile.SetSettings(settingsPrototypeRegistry.CreateSecureProfileSettings());
                    break;
                default:
                    Console.Write("Private Profile (1 = yes): ");
                    newProfile.IsPrivate = Console.ReadLine() == "1";

                    Console.Write("Hide Email (1 = yes): ");
                    newProfile.HideEmail = Console.ReadLine() == "1";

                    Console.Write("Hide Age (1 = yes): ");
                    newProfile.HideAge = Console.ReadLine() == "1";
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Successfully created profile.");
            Console.Write("\n\n\n");

            DisplayProfile(newProfile);

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

            Console.WriteLine();

            Console.WriteLine("Settings");
            Console.WriteLine("------------");
            Console.WriteLine($"Private: {profile.IsPrivate}");
            Console.WriteLine($"Hide Email: {profile.HideEmail}");
            Console.WriteLine($"Hide Age: {profile.HideAge}");
        }
    }
}
