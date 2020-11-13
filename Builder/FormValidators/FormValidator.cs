using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FormValidators
{
    public class FormValidator : IFormValidator
    {
        public void Validate(Form form)
        {
            if(string.IsNullOrEmpty(form.Email))
            {
                throw new Exception("Please enter an email.");
            }

            if (string.IsNullOrEmpty(form.Username))
            {
                throw new Exception("Please enter a username.");
            }
        }
    }
}
