﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ReservationAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Služby a konfigurace rozhraní Web API

            // Trasy rozhraní Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{email}",
                defaults: new { email = RouteParameter.Optional }
            );
        }
    }
}
