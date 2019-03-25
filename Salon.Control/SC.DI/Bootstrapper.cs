using Autofac;
using SC.Core.Repo;
using SC.Core.Service;
using SC.Service;

namespace SC.DI
{
    public class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacContainer();
        }
        public static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ApplicationContext>().AsSelf().InstancePerRequest();


            //Repositories
            builder.RegisterType<SalonRepository>().As<ISalonRepository>();

            //Services
            builder.RegisterType<SalonService>().As<ISalonService>();


            IContainer container = builder.Build();
        }
    }
}
