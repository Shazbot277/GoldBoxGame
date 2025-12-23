using Microsoft.AspNetCore.Mvc;

namespace GoldBoxGame.Controllers
{
	public class PrimaryViewController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Cinema()
		{
			return View();
		}
	}
}
