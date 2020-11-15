using Builder.FormValidators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FormSubmitters
{
    public class FormSubmitterBuilder
    {
        private bool _withReceipt;
        private bool _skipValidation;

        public FormSubmitterBuilder WithReceipt()
        {
            _withReceipt = true;

            return this;
        }

        public FormSubmitterBuilder SkipValidation()
        {
            _skipValidation = true;

            return this;
        }

        public IFormSubmitter Build()
        {
            IFormValidator formValidator = BuildFormValidator();

            IFormSubmitter formSubmitter = new FormSubmitter(formValidator);

            if(_withReceipt)
            {
                formSubmitter = new ReceiptFormSubmitter(formSubmitter);
            }

            return formSubmitter;
        }

        private IFormValidator BuildFormValidator()
        {
            if(_skipValidation)
            {
                return new SkippingFormValidator();
            }

            return new FormValidator();
        }
    }
}
