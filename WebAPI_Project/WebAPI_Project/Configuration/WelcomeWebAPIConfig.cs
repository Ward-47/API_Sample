﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; // used for http

namespace WebAPI_Project.Configuration
{
    public class WelcomeWebAPIConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi", 
                routeTemplate: "api/{controller}/{id}", 
                defaults: new { id = RouteParameter.Optional} 
                );
        }
    }
}