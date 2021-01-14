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

        public bool IsPrivate
        {
            get => _settings.IsPrivate;
            set => _settings.IsPrivate = value;
        }

        public bool HideEmail
        {
            get => _settings.HideEmail;
            set => _settings.HideEmail = value;
        }

        public bool HideAge
        {
            get => _settings.HideAge;
            set => _settings.HideAge = value;
        }

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

        public Profile Clone()
        {
            return new Profile()
            {
                Email = Email,
                Name = Name,
                _dateOfBirth = _dateOfBirth,
                _settings = _settings.Clone()
            };
        }
    }
}
