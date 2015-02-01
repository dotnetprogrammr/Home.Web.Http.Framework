
namespace Home.Web.Http.Framework
{
    using System;
    using System.Net.Http;
    using System.Web.Http.Controllers;
    using System.Web.Http.Dispatcher;

    using Home.Web.Http.Framework.Controllers;

    public class HttpControllerActivator : IHttpControllerActivator
    {
        public IHttpController Create(
            HttpRequestMessage request, 
            HttpControllerDescriptor controllerDescriptor, 
            Type controllerType)
        {
            if (controllerType == typeof(ExceptionController))
            {
                return new ExceptionController();
            }

            return null;
        }
    }
}