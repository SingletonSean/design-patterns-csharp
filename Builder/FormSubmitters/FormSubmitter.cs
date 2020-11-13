using Builder.FormValidators;
using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Builder.FormSubmitters
{
    public class FormSubmitter : IFormSubmitter
    {
        private readonly IFormValidator _validator;

        public FormSubmitter(IFormValidator validator)
        {
            _validator = validator;
        }

        public void Submit(Form form)
        {
            _validator.Validate(form);

            Console.WriteLine("Submitting form...");
            Thread.Sleep(500);
            Console.WriteLine($"Successfully submitted form for {form.Username}.");
        }
    }
}
