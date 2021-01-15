using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SistemaEstoque.App_Start
{
    public class WebApiConfig
    {
        public const string ApiNameControllerOnly = "ApiControllerOnly";
        public const string ApiNameControllerAndAction = "ApiControllerAndAction";

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: ApiNameControllerOnly,
                routeTemplate: "api/{controller}"
            );

            config.Routes.MapHttpRoute(
                name: ApiNameControllerAndAction,
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

        }
    }
}