using Ninject.Modules;
using Ninject;

namespace NinjectSample1
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailSender>().To<MailSender>();
            Bind<ILogging>().To<MockLogging>();
        }
    }
}