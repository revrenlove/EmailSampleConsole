using System.Net;
using System.Net.Mail;

// Email message info
var toEmailAddress = "Recipient's email address";
var subjectLine = "Test Subject Line 1002";
var emailBody = "Test Email Body 1002";

// Your Email Credentials
var emailAddress = "Your Email Address";
var emailPassword = "Your password or app key";

var smtpHost = "smtp.gmail.com";
var smtpPort = 587;

var smtpClient = new SmtpClient
{
    Host = smtpHost,
    Port = smtpPort,
    EnableSsl = true,
    DeliveryMethod = SmtpDeliveryMethod.Network,
    UseDefaultCredentials = false,
    Credentials = new NetworkCredential(emailAddress, emailPassword)
};

using var message = new MailMessage(emailAddress, toEmailAddress, subjectLine, emailBody);
smtpClient.Send(message);