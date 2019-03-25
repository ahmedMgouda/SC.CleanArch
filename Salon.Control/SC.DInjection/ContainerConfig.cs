using Autofac;
using SC.Repository;
using System.Linq;
using System.Reflection;

namespace SC.DInjection
{
    public static class ContainerConfig
    {

        public static void Run()
        {
          var container = Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<>();
                app.run();
            }
        }
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            //Infra
            builder.RegisterType<AppDbContext>();

            //Repositories
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(SC.Repository)))
                .Where(t => t.Namespace.Contains(""))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            //Services 



            return builder.Build();
        }
    }
}
