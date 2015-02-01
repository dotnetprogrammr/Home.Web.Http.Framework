
namespace Home.Web.Http.Framework
{
    using System.Web.Http;
    using System.Web.Http.Dispatcher;
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration configuration = new HttpConfiguration();

            RouteConfig.ConfigureRoutes(configuration);

            configuration.Services.Replace(typeof(IHttpControllerActivator), new HttpControllerActivator());

            appBuilder.UseWebApi(configuration);
        } 
    }
}