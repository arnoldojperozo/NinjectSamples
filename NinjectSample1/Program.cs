using System;
using System.Reflection;
using Ninject;

namespace NinjectSample1
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var mailSender = kernel.Get<IMailSender>();

            var programHandler = new ProgramHandler(mailSender);
            programHandler.Handle("test@test.com");

            Console.ReadLine();
        }
    }

    class ProgramHandler
    {
        private readonly IMailSender mailSender;

        public ProgramHandler(IMailSender _mailSender)
        {
            mailSender = _mailSender;

        }

        public void Handle(string toAddress)
        {
            mailSender.Send(toAddress, "This is not Ninject Sample");
        }
    }
}
