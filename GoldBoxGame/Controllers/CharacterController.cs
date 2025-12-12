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

			//Drizzt.Skills.Add(SkillType.Athletics, Drizzt.GetSkillBonus(SkillType.Athletics));
			//Drizzt.Skills.Add(SkillType.Acrobatics, Drizzt.GetSkillBonus(SkillType.Acrobatics));
			//Drizzt.Skills.Add(SkillType.SleightOfHand, Drizzt.GetSkillBonus(SkillType.SleightOfHand));
			//Drizzt.Skills.Add(SkillType.Stealth, Drizzt.GetSkillBonus(SkillType.Stealth));

			//Drizzt.Skills.Add(SkillType.Arcana, Drizzt.GetSkillBonus(SkillType.Arcana));
			//Drizzt.Skills.Add(SkillType.History, Drizzt.GetSkillBonus(SkillType.History));
			//Drizzt.Skills.Add(SkillType.Investigation, Drizzt.GetSkillBonus(SkillType.Investigation));
			//Drizzt.Skills.Add(SkillType.Nature, Drizzt.GetSkillBonus(SkillType.Nature));
			//Drizzt.Skills.Add(SkillType.Religion, Drizzt.GetSkillBonus(SkillType.Religion));

			//Drizzt.Skills.Add(SkillType.AnimalHandling, Drizzt.GetSkillBonus(SkillType.AnimalHandling));
			//Drizzt.Skills.Add(SkillType.Insight, Drizzt.GetSkillBonus(SkillType.Insight));
			//Drizzt.Skills.Add(SkillType.Medicine, Drizzt.GetSkillBonus(SkillType.Medicine));
			//Drizzt.Skills.Add(SkillType.Perception, Drizzt.GetSkillBonus(SkillType.Perception));
			//Drizzt.Skills.Add(SkillType.Survival, Drizzt.GetSkillBonus(SkillType.Survival));

			//Drizzt.Skills.Add(SkillType.Deception, Drizzt.GetSkillBonus(SkillType.Deception));
			//Drizzt.Skills.Add(SkillType.Intimidation, Drizzt.GetSkillBonus(SkillType.Intimidation));
			//Drizzt.Skills.Add(SkillType.Performance, Drizzt.GetSkillBonus(SkillType.Performance));
			//Drizzt.Skills.Add(SkillType.Persuasion, Drizzt.GetSkillBonus(SkillType.Persuasion));


			//if(Drizzt.Race.AbilityScoreModifiers.Count > 0) {
			//	foreach (var ability in AbilityScoreModifiers)
			//	{ 

			//	}
			//}

			Drizzt.AddFeat("Alert");
			Drizzt.AddFeat("Athlete");

			return View(Drizzt);
		}



		public IActionResult _CharacterSkillSection(Dictionary<SkillType, Skill> skills)
		{
			return PartialView(skills);
		}

		public IActionResult _CharacterSavingThrowsSection(Dictionary<Ability, int> savingThrows)
		{
			return PartialView(savingThrows);
		}
	}
}
