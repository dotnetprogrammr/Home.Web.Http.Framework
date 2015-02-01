
namespace Home.Web.Http.Framework
{
    using System.Web.Http;

    public static class RouteConfig
    {
        public static void ConfigureRoutes(HttpConfiguration configuration)
        {
            // Web API routes
            configuration.MapHttpAttributeRoutes();

            configuration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}