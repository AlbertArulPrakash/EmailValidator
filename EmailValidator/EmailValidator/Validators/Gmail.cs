using Aap.EmailValidator.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailValidator.Validators
{
    public class Gmail : IEmailRule
    {
        public int ConfigurationId { get; set; }
        public string DisallowedCharacters { get; set; }
        public string AllowedCharacters { get; set; }

        public bool Validate(string emailAddress)
        {
            ValidationResult result = new ValidationResult();
            result.IsCatchAll = false;

            // Default is Not valid email. 
            return false;
        }
    }
}
