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

			routes.MapRoute("Default", "{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = UrlParameter.Optional });
		}
	}
}