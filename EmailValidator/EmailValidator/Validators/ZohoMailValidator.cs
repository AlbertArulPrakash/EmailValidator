using Aap.EmailValidator.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailValidator.Validators
{
    class ZohoMailValidator : IEmailRule
    {
        public int ConfigurationId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DisallowedCharacters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AllowedCharacters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Validate(string emailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
