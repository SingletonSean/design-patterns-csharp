using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models
{
    public class Profile
    {
        private DateTime _dateOfBirth;
        private ProfileSettings _settings;

        public string Name { get; set; }
        public string Email { get; set; }
        public int Age => CalculateAge();

        public bool IsPrivate => _settings.IsPrivate;
        public bool HideEmail => _settings.HideEmail;
        public bool HideAge => _settings.HideAge;

        public Profile()
        {
            _settings = new ProfileSettings();
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            _dateOfBirth = dateOfBirth;
        }

        public void SetSettings(ProfileSettings settings)
        {
            _settings = settings;
        }

        private int CalculateAge()
        {
            double ageInDays = TimeSpan.FromTicks(DateTime.Now.Ticks).TotalDays - TimeSpan.FromTicks(_dateOfBirth.Ticks).TotalDays;
            return (int)ageInDays / 365;
        }
    }
}
