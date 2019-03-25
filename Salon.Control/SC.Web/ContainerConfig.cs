using Autofac;
using SC.Repository;
using System.Linq;
using System.Reflection;

namespace SC.Web
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            //Infra
            builder.RegisterType<AppDbContext>();

            //Repositories
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(SC.Repository)))
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            //Services 
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(SC.Repository)))
           .Where(t => t.Name.EndsWith("Service"))
           .AsImplementedInterfaces().InstancePerRequest();

            return builder.Build();
        }
    }
}