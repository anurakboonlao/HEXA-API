using HexaOnlineOrdering.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using HexaOnlineOrdering.Models;
using HexaOnlineOrdering.Api.Options;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

namespace HexaOnlineOrdering.Api.Services
{

    public class EmailService : IEmailService
    {
        private readonly EmailSetting _emailOption;
        private string FromAddress;
        private string MailPassword;   // Mail id password from where mail will be sent.
        private string Port;
        private string Host;
        private string TimeOut;
        private readonly ILogger<EmailService> _logger;

        public EmailService(IOptions<EmailSetting> emailOption, ILogger<EmailService> logger)
        {
            _emailOption = emailOption != null ? emailOption.Value : throw new ArgumentNullException(nameof(emailOption));
            FromAddress = _emailOption.FromAddress;
            MailPassword = _emailOption.FromPassword;
            Port = _emailOption.Port;
            Host = _emailOption.Host;
            TimeOut = _emailOption.Timeout;
            _logger = logger;
    }
        public bool SendEmail(EmailModel targetEmail)
        {
            try
            {
                SmtpClient client = new SmtpClient();

                int numPort;
                int.TryParse(Port, out numPort);

                int numTimeOut;
                int.TryParse(TimeOut, out numTimeOut);

                client.Port = numPort; //outgoing port for the mail.
                client.Host = Host;
                client.Timeout = numTimeOut;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(FromAddress, MailPassword);
                client.EnableSsl = true;              

                // Fill the mail form.
                var send_mail = new MailMessage();

                send_mail.IsBodyHtml = true;
                //address from where mail will be sent.
                send_mail.From = new MailAddress(FromAddress);
                //address to which mail will be sent.           
                send_mail.To.Add(new MailAddress(targetEmail.TargetEmail));
                //subject of the mail.
                send_mail.Subject = targetEmail.MessageSubject;

                send_mail.Body = targetEmail.MessageBody;
                client.Send(send_mail);
                _logger.LogInformation($"SendEmail complete");
                return true;
            }
            catch (Exception ex)
            {              
                _logger.LogInformation($"SendEmail Error : {ex.Message}");
                return false;
            }
        
        }
    }
}
