using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // To add our own page passing (Route) paraments from the browser
            // must create new "MapRoute". Take care to keep the original
            // or default MapRoute method int he bottom. The order of this
            // decleration is important... from declared --> Generics towards
            // the bottom.

            // My created Route Mappings:
            //  Syntax:
            //          1) Name of the RouteMap (Must be unique)
            //          2) Format string to be sent from Browser URL
            //          3) Controller name to use, Action to raise...
            routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new {controller = "Movies", action = "ByReleaseDate"});

            // this is the default Route Map
            routes.MapRoute(
                name: "Default",


                // this is the URL pattern that it read from the browser
                // eg: /movies/propular
                //          then will first go to the Controllers
                //          then will execute a Method in it called "Popular"
                //          
                // eg: /movies/edit/1
                //          then will first go to the Moview Controllers
                //          then will execute a Method in it called "Edit(int id)"
                //              and pass a value ID of '1' as a parameter

                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
