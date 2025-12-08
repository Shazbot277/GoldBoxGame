using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNDLibrary.Class;
using DNDLibrary.Races;
using DNDLibrary.Equipment;

namespace DNDLibrary;

public class Character
{
	public string Name { get; set; }
	public string Background { get; set; }

	public Dictionary<Ability, int> AbilityScores { get; set; } = new()
	{
		{Ability.Strength, 10},
		{Ability.Dexterity, 10},
		{Ability.Constitution, 10},
		{Ability.Intelligence, 10},
		{Ability.Wisdom, 10},
		{Ability.Charisma, 10}
	};

	public int ProficiencyBonus { get; set; } = 2;

	public HashSet<SkillType> ProficientSkills { get; set; } = new();

	public List<SkillType> Proficiencies { get; set; } = new();

	public List<Language> Languages { get; set; } = new();

	public List<RacialTrait> Traits { get; set; } = new();

	public IRace Race { get; private set; }

	public void SetRace(IRace race)
	{
		Race = race;
		race.ApplyTo(this);
	}

	public int GetAbilityModifier(Ability ability)
	{
		int score = AbilityScores[ability];
		return (score - 10) / 2;
	}

	public int GetSkillBonus(SkillType skill)
	{
		var data = SkillDatabase.Skills[skill];
		int mod = GetAbilityModifier(data.Ability);

		if (ProficientSkills.Contains(skill))
			mod += ProficiencyBonus;
		return mod;
	}

	public ICharacterClass CharacterClass { get; private set; }

	public int Level { get; private set; }


	List<Equipment.Equipment> Inventory { get; set; } = new();

	public Character()
	{
	}

	public void SetClass(ICharacterClass characterClass, int level = 1)
	{
		CharacterClass = characterClass;
		Level = level;
	}

	public List<string> GetFeatures()
	{ 
		var features = new List<string>();

		for (int lvl = 1; lvl <= Level; lvl++)
		{
			var f = CharacterClass.GetFeaturesForLevel(lvl);
			if(f != null)
				features.AddRange(f.Features);
		}
		return features;
	}





	public static void TarlCharacter()
	{
		Character tarl = new Character();
		tarl.Name = "Tarl";
		tarl.SetRace(new Human());
		tarl.ProficiencyBonus = 2;


		//Initial Ability Scores (future character will roll die)
		tarl.AbilityScores[Ability.Strength] = Roll.InitialAbilityScore();
		tarl.AbilityScores[Ability.Dexterity] = Roll.InitialAbilityScore();
		tarl.AbilityScores[Ability.Intelligence] = Roll.InitialAbilityScore();
		tarl.AbilityScores[Ability.Wisdom] = Roll.InitialAbilityScore();
		tarl.AbilityScores[Ability.Constitution] = Roll.InitialAbilityScore();
		tarl.AbilityScores[Ability.Charisma] = Roll.InitialAbilityScore();

		tarl.Languages.Add(Language.Dwarvish);

		tarl.ProficientSkills.Add(SkillType.Religion);
		tarl.Proficiencies.Add(SkillType.Persuasion);


		tarl.SetClass(new Fighter(), 1);
		tarl.Inventory.Add(Equipment.EquipmentList.Get("Sword"));
		tarl.Inventory.Add(Equipment.EquipmentList.Get("Shield"));
		tarl.Inventory.Add(Equipment.EquipmentList.Get("Club"));


		//tarl.SetRace(new Dragonborn(DraconicAncestry.DragonType.Blue));

	}
}
