using Facade.Exceptions;
using Facade.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Facade.Services.UserPreferencesRepositories
{
    public class FileUserPreferencesRepository
    {
        private const string USERS_DIRECTORY_NAME = "users";
        private const string USER_PREFERENCES_FILE_NAME = "preferences.json";

        public async Task<UserPreferences> GetByUserId(Guid userId)
        {
            string userPreferencesFilePath = Path.Combine(USERS_DIRECTORY_NAME, userId.ToString(), USER_PREFERENCES_FILE_NAME);

            string userPreferencesJson = await File.ReadAllTextAsync(userPreferencesFilePath);
            UserPreferences userPreferences = JsonSerializer.Deserialize<UserPreferences>(userPreferencesJson);

            return userPreferences;
        }
    }
}
