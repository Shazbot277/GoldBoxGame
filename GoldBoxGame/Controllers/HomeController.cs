using DNDLibrary;
using DNDLibrary.Class;
using DNDLibrary.Races;
using GoldBoxGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System.Diagnostics;


//dnd5eapi.co
//https://www.dnd5eapi.co/api/2014/equipment/
//https://www.dnd5eapi.co/api/2014/equipment/longswordhttps://www.dnd5eapi.co/api/2014/equipment/longsword
//https://www.dnd5eapi.co/api/2014/equipment/spear



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
	

		public IActionResult MyCharacter(int? id)
		{
			if (id.HasValue)
			{
				switch (id.Value)
				{
					case 1: return View(DNDLibrary.CharacterFactory.CreateDrizzt());
					case 2: return View(DNDLibrary.CharacterFactory.CreateBruenor());
					case 3: return View(DNDLibrary.CharacterFactory.CreateWulfgar());
				}
			}
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

		public IActionResult _SetProficiencyBonusView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetInspirationView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetPassiveWisdomView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetArmorClass(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetInitiativeView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetSpeedView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetHitPointsView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetTemporaryHitPointsView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetHitDice(Character character)
		{ 
			return PartialView(character);
		}

		public IActionResult _SetDeathSavesView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetAlignmentView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetRaceNameView(Character character)
		{
			return PartialView(character);
		}


		public IActionResult _SetExpView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetClassNameView(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _SetInventoryView(Character character)
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
