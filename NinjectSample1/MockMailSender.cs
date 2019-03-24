using System;
namespace NinjectSample1
{
    public class MockMailSender : IMailSender
    {
        public void Send(string toAddress, string subject)
        {
            Console.WriteLine("Mocking mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}