using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FCExcelExport_WebAPI_Sample_Server
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            FCExcelExport_WebApi.WebApiConfig.Register(config);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
