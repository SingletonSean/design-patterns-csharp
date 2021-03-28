using Facade.Exceptions;
using Facade.Models;
using Facade.Services.UserPreferencesRepositories;
using Facade.Services.UserRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Services
{
    public class ProfileReaderFacade
    {
        private readonly DatabaseUserRepository _userRepository;
        private readonly FileUserPreferencesRepository _userPreferencesRepository;

        public ProfileReaderFacade(DatabaseUserRepository userRepository, FileUserPreferencesRepository userPreferencesRepository)
        {
            _userRepository = userRepository;
            _userPreferencesRepository = userPreferencesRepository;
        }

        /// <summary>
        /// Get a profile by a user's username.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <returns>The profile for the user.</returns>
        /// <exception cref="ForbiddenProfileReadException">Thrown if the profile is private.</exception>
        public async Task<Profile> GetByUsername(string username)
        {
            User user = await _userRepository.GetByUsername(username);
            UserPreferences preferences = await _userPreferencesRepository.GetByUserId(user.Id);

            if (preferences.IsPrivate)
            {
                throw new ForbiddenProfileReadException();
            }

            Profile profile = new Profile()
            {
                Username = user.Username,
                ColorTheme = preferences.ColorTheme
            };

            return profile;
        }
    }
}
