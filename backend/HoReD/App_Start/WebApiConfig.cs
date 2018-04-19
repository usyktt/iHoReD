﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HoReD
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
          
            // Web API routes
            config.MapHttpAttributeRoutes();

           // System.Configuration.ConfigurationSettings.AppSettings["FrontURL"] = Environment.GetEnvironmentVariable("APPSETTING_FrontURL");
            
           /* #if (DEBUG)
                System.Configuration.ConfigurationSettings.AppSettings["FrontURL"] = "http://localhost:3000";
            #else
                System.Configuration.ConfigurationSettings.AppSettings["FrontURL"] = "https://hored-frontend.azurewebsites.net";
            #endif */
                
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
