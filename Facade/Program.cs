﻿using Facade.Models;
using Facade.Services;
using Facade.Services.UserPreferencesRepositories;
using Facade.Services.UserRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("users").Options;
            UsersDbContext context = new UsersDbContext(options);
            await Seed(context);

            DatabaseUserRepository userRepository = new DatabaseUserRepository(context);
            FileUserPreferencesRepository userPreferencesRepository = new FileUserPreferencesRepository();

            await Run(userRepository, userPreferencesRepository);
        }

        private static async Task Run(DatabaseUserRepository userRepository, FileUserPreferencesRepository userPreferencesRepository)
        {

        }

        private static async Task Seed(UsersDbContext context)
        {
            Guid userId = await SeedUser(context);
            await SeedUserPreferences(userId);
        }

        private static async Task<Guid> SeedUser(UsersDbContext context)
        {
            User user = new User()
            {
                Email = "test@gmail.com",
                Username = "SingletonSean"
            };
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return user.Id;
        }

        private static async Task SeedUserPreferences(Guid userId)
        {
            string userPath = Path.Combine("users", userId.ToString());
            Directory.CreateDirectory(userPath);

            UserPreferences userPreferences = new UserPreferences()
            {
                IsPrivate = true,
                ColorTheme = ColorTheme.Dark
            };
            string userPreferencesJson = JsonSerializer.Serialize(userPreferences);

            string userPreferencesPath = Path.Combine(userPath, "preferences.json");
            await File.WriteAllTextAsync(userPreferencesPath, userPreferencesJson);
        }
    }
}