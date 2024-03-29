﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StoreMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "EquipmentDetails",
               url: "equipment-{id}.html",
               defaults: new { controller = "Equipment", action = "Details" });

            routes.MapRoute(
                name: "EquipmentList",
                url: "Category/{categoryName}",
                defaults: new { controller = "Equipment", action = "List" });

            routes.MapRoute(
                name: "StaticSites",
                url: "sites/{name}.html",
                defaults: new { controller = "Home", action = "StaticSites" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
