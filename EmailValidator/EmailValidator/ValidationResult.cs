using System;
using System.Collections.Generic;
using System.Text;

namespace EmailValidator
{
    public class ValidationResult
    {
        /// <summary>
        /// The input email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The domain of the email address.
        /// </summary>
        public string DomainName { get; set; }
        /// <summary>
        /// Whether the email address is from a free email provider like Gmail or Hotmail.
        /// <returns>Returns True or False</returns>
        /// </summary>
        public bool IsFree { get; set; }
        /// <summary>
        /// Whether the email address is a catch-all address.
        /// <returns>Returns True or false</returns>
        /// </summary>
        public bool IsCatchAll { get; set; }
        /// <summary>
        /// Whether the email address has a valid MX record in its DNS entries.
        /// <returns>Return values: True, False, -  (- means not applicable)</returns>
        /// </summary>
        public bool IsDomain { get; set; }
        /// <summary>
        /// Whether the email address is syntactically correct.
        /// <returns>Return values: True, False</returns>
        /// </summary>
        public bool IsSyntax { get; set; }
        /// <summary>
        /// Whether the mail servers specified in the MX records are responding to connections.
        /// <returns>Return values: True, False, -  (- means not applicable)</returns>
        /// </summary>
        public bool IsSmtp { get; set; }
        /// <summary>
        /// Whether the mail server confirms that the email address actually exist.
        /// <returns>Return values: True, False, -  (- means not applicable)</returns>
        /// </summary>
        public bool IsVerified { get; set; }

        /// <summary>
        /// Whether the mail server is currently down or unresponsive.
        /// <returns>Return values: True, False, -  (- means not applicable)</returns>
        /// </summary>
        public bool IsServerDown { get; set; }
        /// <summary>
        /// Whether the mail server employs greylisting where an email has to be sent a second time at a later time.
        /// <returns>Return values: True, False, -  (- means not applicable)</returns>
        /// </summary>
        public bool IsGrayListed { get; set; }
        /// <summary>
        /// Whether the email address is a temporary one from a disposable email provider.
        /// <returns>Return values: True, False, -  (- means not applicable)</returns>
        /// </summary>
        public bool IsDisposable { get; set; }
        /// <summary>
        /// Whether the email address is in our blacklist.
        /// <returns>Return values: True, False, -  (- means not applicable)</returns>
        /// </summary>
        public bool IsSuppressed { get; set; }
        /// <summary>
        /// Whether the email address is a role-based email address like admin@example.net or webmaster@example.net.
        /// <retruns>Return values: True, False, -  (- means not applicable)</retruns>
        /// </summary>
        public bool IsRole { get; set; }
        /// <summary>
        /// Whether the email address contains high risk keywords.
        /// <returns>Return values: True, False, -  (- means not applicable)</returns>
        /// </summary>
        public bool IsHighRisk { get; set; }
        /// <summary>
        /// Email address reputation score. Score > 0.70 means good; score > 0.40 means fair; score ≤ 0.40 means poor.
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// The time taken to get the results in seconds.
        /// </summary>
        public float TimeTaken { get; set; }
        /// <summary>
        /// Whether our system think the email address is valid based on all the previous fields.
        /// <returns>Return values: True, False</returns>
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// The number of credits left to perform validations.
        /// </summary>
        public int Credits { get; set; }
        /// <summary>
        /// The error code if there is any error. See error table below.
        /// </summary>
        public string ErrorCode { get; set; }
        /// <summary>
        /// The error message if there is any error. See error table below.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
