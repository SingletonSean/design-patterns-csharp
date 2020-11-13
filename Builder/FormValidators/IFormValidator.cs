using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FormValidators
{
    public interface IFormValidator 
    {
        /// <summary>
        /// Validate a form.
        /// </summary>
        /// <param name="form">The form to validate.</param>
        /// <exception cref="Exception">Thrown if form is invalid.</exception>
        void Validate(Form form);
    }
}
