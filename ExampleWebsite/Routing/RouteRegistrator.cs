using System.Web.Mvc;
using System.Web.Routing;
using MvcTurbine.Routing;

namespace ExampleWebsite.Routing
{
	public class RouteRegistrator : IRouteRegistrator
	{
		public void Register(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			// this is my temporary fix. not having a default route would be better.
			routes.IgnoreRoute("{assembly}/Content/{*pathInfo}");
			routes.IgnoreRoute("{assembly}/Scripts/{*pathInfo}");

			// the default route intercepts paths to non physical files expecting a controller 
			routes.MapRoute("Default", "{controller}/{action}/{id}",
			    new { controller = "Home", action = "Index", id = UrlParameter.Optional });

		}
	}
}