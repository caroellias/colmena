using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace REST
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                //ruta a la cual se realizan las peticiones al servidor http://localhost:21526
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.EnableSystemDiagnosticsTracing();
        }
    }
}
