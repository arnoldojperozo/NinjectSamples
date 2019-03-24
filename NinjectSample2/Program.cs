using System;
using Ninject;

namespace NinjectSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var kernel = new StandardKernel())
            {
                kernel.Bind<ILogger>().To<ConsoleLogger>();
                var mailService = kernel.Get<MailService>();
                mailService.SendMail("someone@domain.com", "Hi", null);
            }
        }
    }
}
