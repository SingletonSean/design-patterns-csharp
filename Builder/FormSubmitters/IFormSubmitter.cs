using System;
using Builder.Models;

namespace Builder.FormSubmitters
{
    public interface IFormSubmitter
    {
        /// <summary>
        /// Submit a form.
        /// </summary>
        /// <param name="form">The form to submit.</param>
        /// <exception cref="Exception">Thrown if form is invalid.</exception>
        void Submit(Form form);
    }
}