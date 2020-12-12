
namespace Aap.EmailValidator.Validators
{
    /// <summary>
    /// IEmailRule interface ensures the minimum standard properties that are needed for a validator
    /// </summary>
    public interface IEmailRule
    {
        int ConfigurationId { get; set; }
        /// <summary>
        /// Get or Set the characters that are disallowed in a username. 
        /// </summary>
        string DisallowedCharacters { get; set; }
        /// <summary>
        /// Get or Set the characters that are allowed in a username
        /// </summary>
        string AllowedCharacters { get; set; }

        /// <summary>
        /// Validate method validates the email rules that are set for individual email provider. 
        /// This method validates the allowed and disallowed characters and other username grammar that is set by the email provider. 
        /// e.g. Username should start with a letter or a digit. 
        /// </summary>
        /// <param name="emailAddress">Email address to validate</param>
        /// <returns>True if the email address pass the validation<br />False if the email address did not pass the validation</returns>
        bool Validate(string emailAddress);
    }
}
