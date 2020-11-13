using Builder.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Builder.FormSubmitters
{
    public class ReceiptFormSubmitter : IFormSubmitter
    {
        private readonly IFormSubmitter _formSubmitter;

        public ReceiptFormSubmitter(IFormSubmitter formSubmitter)
        {
            _formSubmitter = formSubmitter;
        }

        public void Submit(Form form)
        {
            _formSubmitter.Submit(form);

            Console.WriteLine("Sending receipt...");
            Thread.Sleep(500);
            Console.WriteLine($"Successfully sent form submission receipt to {form.Email}.");
        }
    }
}
