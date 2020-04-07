using Aap.EmailValidator.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailValidator.Validators
{
    class Gmail : IEmailRule
    {
        public int Configuration { get; set; }
        public string DisallowedCharacters { get; set; }
        public string AllowedCharacters { get; set; }

        public bool Validate(string emailAddress)
        {

            // Default is Not valid email. 
            return false;
        }
    }
}
