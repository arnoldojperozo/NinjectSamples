using System;

namespace NinjectSample1
{
    public class MailSender : IMailSender
    {
        private readonly ILogging logging;

        public MailSender(ILogging logging)
        {
            this.logging = logging;
        }

        public void Send(string toAddress, string subject)
        {
            logging.Debug("Sending mail");
            Console.WriteLine(string.Format("Sending mail to [{0}] with subject [{1}]", toAddress, subject));
        }
    }
}
