using DNDLibrary;
using DNDLibrary.Class;
using DNDLibrary.Equipment;
using DNDLibrary.Races;
using Microsoft.AspNetCore.Mvc;

namespace GoldBoxGame.Controllers
{
	public class CharacterController : Controller
	{
		public IActionResult Index()
		{
			Character Drizzt = new Character();
			Drizzt.Name = "Drizzt Do'Urden";
			Drizzt.Alignment = Alignment.ChaoticGood;


			EquipmentList.GetAllWeapons();

			Drizzt.SetRace(new DrowElf());
			Drizzt.SetClass(new Ranger(), 1);

			Drizzt.Inventory = Drizzt.CharacterClass.StartingEquipment;

			Drizzt.AbilityScores[Ability.Strength] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Dexterity] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Intelligence] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Wisdom] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Constitution] = Roll.InitialAbilityScore();
			Drizzt.AbilityScores[Ability.Charisma] = Roll.InitialAbilityScore();

			Drizzt.Race.AbilityScoreModifiers.ToList().ForEach(mod =>
			{
				Drizzt.AbilityScores[mod.Key] += mod.Value;
				//Drizzt.AbilityModifier[mod.Key] = Drizzt.GetAbilityModifier(mod.Key);
			});


			Drizzt.MaxHitPoints = Drizzt.CurrentHitPoints = Drizzt.CharacterClass.HitDie + Drizzt.AbilityScores[Ability.Constitution];
			Drizzt.TemporaryHitPoints = 0;


            Drizzt.AbilityModifier.Add(Ability.Strength, Drizzt.GetAbilityModifier(Ability.Strength));
			Drizzt.AbilityModifier.Add(Ability.Dexterity, Drizzt.GetAbilityModifier(Ability.Dexterity));
			Drizzt.AbilityModifier.Add(Ability.Intelligence, Drizzt.GetAbilityModifier(Ability.Intelligence));
			Drizzt.AbilityModifier.Add(Ability.Wisdom, Drizzt.GetAbilityModifier(Ability.Wisdom));
			Drizzt.AbilityModifier.Add(Ability.Constitution, Drizzt.GetAbilityModifier(Ability.Constitution));
			Drizzt.AbilityModifier.Add(Ability.Charisma, Drizzt.GetAbilityModifier(Ability.Charisma));


			Drizzt.SavingThrows.Add(Ability.Strength, Drizzt.GetSavingThrowBonus(Ability.Strength));
			Drizzt.SavingThrows.Add(Ability.Dexterity, Drizzt.GetSavingThrowBonus(Ability.Dexterity));
			Drizzt.SavingThrows.Add(Ability.Intelligence, Drizzt.GetSavingThrowBonus(Ability.Intelligence));
			Drizzt.SavingThrows.Add(Ability.Wisdom, Drizzt.GetSavingThrowBonus(Ability.Wisdom));
			Drizzt.SavingThrows.Add(Ability.Constitution, Drizzt.GetSavingThrowBonus(Ability.Constitution));
			Drizzt.SavingThrows.Add(Ability.Charisma, Drizzt.GetSavingThrowBonus(Ability.Charisma));

			
			foreach (var item in Drizzt.Skills)
			{
				Skill skill = item.Value;
				int mod = Drizzt.AbilityModifier[skill.Ability];
				skill.Modifier = mod;

				if(Drizzt.Proficiencies.Contains(skill.Type))
				{
					skill.Modifier += 2;
				}
			}


			Drizzt.ArmorClass = Drizzt.SetArmorClass();

			Drizzt.SetPassiveWisdom();

			Drizzt.AddFeat("Alert");
			Drizzt.AddFeat("Athlete");

			return View(Drizzt);
		}



		public IActionResult _CharacterSkillSection(Dictionary<SkillType, Skill> skills)
		{
			return PartialView(skills);
		}

		public IActionResult _CharacterSavingThrowsSection(Character character)
		{
			return PartialView(character);
		}

		public IActionResult _CharacterAttributesSection(Character character)
		{
			return PartialView(character);
		}
	}
}
