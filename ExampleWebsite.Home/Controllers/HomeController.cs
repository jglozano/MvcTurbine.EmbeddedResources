using System.Web.Mvc;

namespace ExampleWebsite.Home.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View("Index");
		}
	}
}