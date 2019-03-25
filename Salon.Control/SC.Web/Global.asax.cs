using SC.Web.Mappings;
using System.Web.Mvc;
using System.Web.Routing;

namespace SC.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Init database
            //System.Data.Entity.Database.SetInitializer(new SCSeedData());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Autofac and Automapper configurations
            ContainerConfig.Configure();
            AutoMapperConfiguration.Configure();
        }
    }
}
