using System;

namespace NinjectSample1
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}
