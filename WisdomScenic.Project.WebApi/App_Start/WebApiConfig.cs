using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WisdomScenic.Project.Attributes.API;
namespace WisdomScenic.Project.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Filters.Add(new ApiSecurityFilter());
            config.Filters.Add(new ApiExceptionFilter());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
