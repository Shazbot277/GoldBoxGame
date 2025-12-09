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
			Character Drizzt = new Character();
			Drizzt.Name = "Drizzt Do'Urden";
			Drizzt.SetRace(new DrowElf());

			Drizzt.AbilityScores[Ability.Strength] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Dexterity] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Intelligence] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Wisdom] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Constitution] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Charisma] = Roll.InitialAbilityScore();

			Drizzt.SetClass(new Ranger(), 1);

			Drizzt.AddFeat("Alert");
			Drizzt.AddFeat("Athlete");

			return View();
		}

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
