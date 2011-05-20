using System.Web.Mvc;
using System.Web.Routing;
using MvcTurbine.Routing;

namespace ExampleWebsite.Home.Routing
{
	public class RouteRegistrator : IRouteRegistrator
	{
		public void Register(RouteCollection routes)
		{
			routes.MapRoute("Home", string.Empty, new { controller = "Home", action = "Index" });
		}
	}
}