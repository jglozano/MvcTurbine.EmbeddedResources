using System.Web.Mvc;
using System.Web.Routing;
using MvcTurbine.Routing;

namespace ExampleWebsitePage.Routing
{
	public class RouteRegistrator : IRouteRegistrator
	{
		public void Register(RouteCollection routes)
		{
			routes.MapRoute("SamplePage", "SamplePage", new { controller = "SamplePage", action = "Index" });
		}
	}
}