using DNDLibrary;
using DNDLibrary.Class;
using DNDLibrary.Races;
using GoldBoxGame.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoldBoxGame.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return RedirectToAction("MyCharacter");
		}


		#region My DND Character
	

		public IActionResult MyCharacter()
		{
			DNDLibrary.Character character = DNDLibrary.CharacterFactory.CreateDrizzt();
			return View(character);
		}

		public IActionResult _AbilityCardView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _ProficiencyBonusView(Character character)
		{
			return PartialView(character);
		}

		#endregion


		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
