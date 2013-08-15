using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Routing;

namespace DistributedServices.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            ShiftRoutes(config);

            ShiftTypeRoutes(config);

            SeasonRoutes(config);

            PriorityRoutes(config);
        }

        private static void ShiftRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "ShiftGetAll",
                routeTemplate: "api/shifts",
                defaults: new { controller = "Shift", action = "GetAll" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "Shift",
                routeTemplate: "api/shifts/{id}",
                defaults: new { controller = "Shifts", action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "ShiftPost",
                routeTemplate: "api/shifts",
                defaults: new { controller = "Shifts", action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );

            config.Routes.MapHttpRoute(
                name: "ShiftPut",
                routeTemplate: "api/shifts/{id}",
                defaults: new { controller = "Shifts", action = "Put" },
                constraints: new { httpMethod = new HttpMethodConstraint("PUT") }
                );

            config.Routes.MapHttpRoute(
                name: "ShiftDelete",
                routeTemplate: "api/shifts/{id}",
                defaults: new { controller = "Shifts", action = "Delete" },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") }
                );
        }

        private static void ShiftTypeRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "ShiftTypeGetAll",
                routeTemplate: "api/shifttypes",
                defaults: new { controller = "ShiftTypes", action = "GetAll" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "ShiftTypeGet",
                routeTemplate: "api/shifttypes/{id}",
                defaults: new { controller = "ShiftTypes", action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "ShiftTypePost",
                routeTemplate: "api/shifttypes",
                defaults: new { controller = "ShiftTypes", action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );

            config.Routes.MapHttpRoute(
                name: "ShiftTypePut",
                routeTemplate: "api/shifttypes/{id}",
                defaults: new { controller = "ShiftTypes", action = "Put" },
                constraints: new { httpMethod = new HttpMethodConstraint("PUT") }
                );

            config.Routes.MapHttpRoute(
                name: "ShiftTypeDelete",
                routeTemplate: "api/shifttypes/{id}",
                defaults: new { controller = "ShiftTypes", action = "Delete" },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") }
                );
        }

        private static void SeasonRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "SeasonGetAll",
                routeTemplate: "api/seasons",
                defaults: new { controller = "Seasons", action = "GetAll" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "SeasonGet",
                routeTemplate: "api/seasons/{id}",
                defaults: new { controller = "Seasons", action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "SeasonPost",
                routeTemplate: "api/seasons",
                defaults: new { controller = "Seasons", action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );

            config.Routes.MapHttpRoute(
                name: "SeasonPut",
                routeTemplate: "api/seasons/{id}",
                defaults: new { controller = "Seasons", action = "Put" },
                constraints: new { httpMethod = new HttpMethodConstraint("PUT") }
                );

            config.Routes.MapHttpRoute(
                name: "SeasonDelete",
                routeTemplate: "api/seasons/{id}",
                defaults: new { controller = "Seasons", action = "Delete" },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") }
                );
        }

        private static void PriorityRoutes(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "PriorityGetAll",
                routeTemplate: "api/priorities",
                defaults: new { controller = "Priorities", action = "GetAll" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "PriorityGet",
                routeTemplate: "api/priorities/{id}",
                defaults: new { controller = "Priorities", action = "Get" },
                constraints: new { httpMethod = new HttpMethodConstraint("GET") }
                );

            config.Routes.MapHttpRoute(
                name: "PriorityPost",
                routeTemplate: "api/priorities",
                defaults: new { controller = "Priorities", action = "Post" },
                constraints: new { httpMethod = new HttpMethodConstraint("POST") }
                );

            config.Routes.MapHttpRoute(
                name: "PriorityPut",
                routeTemplate: "api/priorities/{id}",
                defaults: new { controller = "Priorities", action = "Put" },
                constraints: new { httpMethod = new HttpMethodConstraint("PUT") }
                );

            config.Routes.MapHttpRoute(
                name: "PriorityDelete",
                routeTemplate: "api/priorities/{id}",
                defaults: new { controller = "Priorites", action = "Delete" },
                constraints: new { httpMethod = new HttpMethodConstraint("DELETE") }
                );
        }
    }
}
