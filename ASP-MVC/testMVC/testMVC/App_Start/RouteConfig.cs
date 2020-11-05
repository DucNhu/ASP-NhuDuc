using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace testMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //// MyName
            routes.MapRoute(
            name: "Hello",
            url: "{controller}/{action}/{name}/{num}",
            defaults: new { controller = "HelloWorld", action = "Index", id = UrlParameter.Optional } );

            ////Product
            //routes.MapRoute(
            //name: "MyName",
            //url: "{controller}}/{action}/{name}/{id}");

        ////Index
        //routes.MapRoute(
        //name: "MyName",
        //url: "{controller}}/{action}/{name}/{id}");

        //Display
            routes.MapRoute(
                name: "{Product}", 
                url: "{controller}/{action}/{name}/{id}/{category}",
                defaults: new { controller = "Product", action = "Display", id = UrlParameter.Optional }
            );
        }
    }

}