# EmailValidator
An email validator that validates an email not just by its email syntax but also include the validation based on individual domain  based rules and DNS

Why a new email validator when there is already a lot other validators in the market. 

Today most of us who are writing code to validate email would come across this link in hacked.com which speaks about what we do not know about validating an email address. https://haacked.com/archive/2007/08/21/i-knew-how-to-validate-an-email-address-until-i.aspx/ This article talks about the RFC that defines what's an email address. 

However speaking, An email address defined by RFC is not always used in the same way by every email providers. E.g. # is an allowed character for username. Almost all the world use a personal email address provided by either an ISP or an email provider like Gmail, Yahoo, they do pose their own rules. One example of such rule in gmail is, local username part should not start or end with a special character. Though special character in an username is allowed,  the email provider implement their restrictions. 

While Validating an email address for it's validity, most developers tend to forget the rules imposed by email providers. This too give raise to false positives since, almost all free email providers tend to return status as valid email when tested using SMTP commands. 

This is where AAP EmailValidator comes in. This email validator helps you to understand the grammar of the username of specific email provider and add that validation as one layer of validation before connecting to the provider. This reduces flooding of email server which most times doesn't reject
