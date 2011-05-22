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

			//// This is an ugly hack to allow a default route. It is best to not use one.
			//routes.IgnoreRoute("{assembly}/Content/{*pathInfo}");
			//routes.IgnoreRoute("{assembly}/Scripts/{*pathInfo}");

			//// A default route intercepts paths to non physical files. Do not use one.
			//routes.MapRoute("Default", "{controller}/{action}/{id}",
			//    new { controller = "Home", action = "Index", id = UrlParameter.Optional });
		}
	}
}