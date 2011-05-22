using System.Web.Mvc;

namespace ExampleWebsitePage.Controllers
{
	public class SamplePageController : Controller
	{
		public ActionResult Index()
		{
			return View("Index");
		}
	}
}