using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNDLibrary.Class;
using DNDLibrary.Races;
using DNDLibrary.Equipment;
using DNDLibrary.Feats;

namespace DNDLibrary;

public class Character
{
	public string Name { get; set; }
	public string Background { get; set; }

	public Alignment Alignment { get; set; }

	public int Gold { get; set; }

	public int InitiativeBonus { get; set; } = 0;

	public int Inspiration { get; set; } = 0;

	public int Speed { get; set; } = 30;

	public int ArmorClass { get; set; } = 10;

    public int Level { get; private set; }

	public int MaxHitPoints { get; set; } = 0;
	public int CurrentHitPoints { get; set; } = 0;
	public int TemporaryHitPoints { get; set; } = 0;


    public List<string> Feats { get; set; } = new();

	public Dictionary<Ability, int> AbilityScores { get; set; } = new()
	{
		{Ability.Strength, 10},
		{Ability.Dexterity, 10},
		{Ability.Constitution, 10},
		{Ability.Intelligence, 10},
		{Ability.Wisdom, 10},
		{Ability.Charisma, 10}
	};

	public Dictionary<Ability, int> AbilityModifier { get; set; } = new();

	public int ProficiencyBonus { get; set; } = 2;

	[Obsolete]
	public HashSet<SkillType> ProficientSkills { get; set; } = new();

	public Dictionary<SkillType, Skill> Skills { get; set; } = SkillDatabase.Skills;

	public List<SkillType> Proficiencies { get; set; } = new();

	public Dictionary<Ability, int> SavingThrows { get; set; } = new();

	public List<Language> Languages { get; set; } = new();

	public List<RacialTrait> Traits { get; set; } = new();

	public IRace Race { get; private set; }

	public ICharacterClass CharacterClass { get; private set; }

	


	public List<Equipment.Equipment> Inventory { get; set; } = new();


	public Character()
	{
	}

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

		if (Proficiencies.Contains(skill))
			mod += ProficiencyBonus;
		return mod;
	}

	public int GetSavingThrowBonus(Ability ability)
	{
		int mod = GetAbilityModifier(ability);
		if (CharacterClass.SavingThrowProficiencies.Contains(ability))
			mod += ProficiencyBonus;
		return mod;
	}


	public void SetClass(ICharacterClass characterClass, int level = 1)
	{
		CharacterClass = characterClass;
		Level = level;
	}


	#region Feats Region

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

	public void IncreaseAbility(Ability ability, int amount)
	{
		if (AbilityScores.ContainsKey(ability))
			AbilityScores[ability] += amount;
		else
			AbilityScores[ability] = amount;
	}

	public void AddFeat(string featName)
	{
		Feat feat = FeatList.Get(featName);
		if (feat == null) return;

		if (feat.CanTake(this))
		{
			Feats.Add(feat.Name);

			if (feat.GrantsAbilityIncrease && feat.AbilityIncrease.HasValue)
				IncreaseAbility(feat.AbilityIncrease.Value, feat.IncreaseAmount);

			feat.ApplyEffect(this);
		}
		else
		{
			Console.WriteLine($"Character does not meet prerequisites for {featName}");
		}
	}

	public int GetAbilityScore(Ability ability)
	{
		return AbilityScores.ContainsKey(ability) ? AbilityScores[ability] : 0;
	}
	#endregion


	public int SetArmorClass()
	{ 
		return 10 + GetAbilityModifier(Ability.Dexterity);
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

		//tarl.ProficientSkills.Add(SkillType.Religion);
		tarl.Proficiencies.Add(SkillType.Athletics);
		tarl.Proficiencies.Add(SkillType.Persuasion);


		tarl.SetClass(new Fighter(), 1);
		tarl.Inventory.Add(Equipment.EquipmentList.Get("Sword"));
		tarl.Inventory.Add(Equipment.EquipmentList.Get("Shield"));
		tarl.Inventory.Add(Equipment.EquipmentList.Get("Club"));


		tarl.Gold = tarl.CharacterClass.StartingGold;

		//tarl.SetRace(new Dragonborn(DraconicAncestry.DragonType.Blue));

	}
}
