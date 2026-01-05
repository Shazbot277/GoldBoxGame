using DNDLibrary.Class;
using DNDLibrary.Equipment;
using DNDLibrary.Races;

namespace DNDLibrary;

public static class CharacterFactory
{
	public static Character CreateDrizzt()
	{
		Character Drizzt = new Character();
		Drizzt.Name = "Drizzt Do'Urden";
		Drizzt.Alignment = Alignment.ChaoticGood;
		Drizzt.Id = 1;


		EquipmentList.GetAllWeapons();

		Drizzt.SetRace(new DrowElf());
		Drizzt.SetClass(new Ranger(), 1);

		Drizzt.Inventory = Drizzt.CharacterClass.StartingEquipment;

		//Set Equipped Items
		Drizzt.EquipArmor(EquipmentList.Get("Studded Leather Armor"));
		Drizzt.EquipMainHand(EquipmentList.Get("Scimitar"));
		Drizzt.EquipOffHand(EquipmentList.Get("Shortsword"));


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

			if (Drizzt.Proficiencies.Contains(skill.Type))
			{
				skill.Modifier += 2;
			}
		}

		Drizzt.ArmorClass = Drizzt.SetArmorClass();

		Drizzt.SetPassiveWisdom();

		Drizzt.AddFeat("Alert");
		Drizzt.AddFeat("Athlete");

		return Drizzt;
	}

	public static Character CreateBruenor()
	{
		Character character = new Character();
		character.Name = "Bruenor Battlehammer";
		character.Alignment = Alignment.ChaoticGood;
		character.Id = 2;


		EquipmentList.GetAllWeapons();

		character.SetRace(new MountainDwarf());
		character.SetClass(new Fighter(), 1);

		character.Inventory = character.CharacterClass.StartingEquipment;

		character.AbilityScores[Ability.Strength] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Dexterity] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Intelligence] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Wisdom] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Constitution] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Charisma] = Roll.InitialAbilityScore();

		character.Race.AbilityScoreModifiers.ToList().ForEach(mod =>
		{
			character.AbilityScores[mod.Key] += mod.Value;
		});


		character.MaxHitPoints = character.CurrentHitPoints = character.CharacterClass.HitDie + character.AbilityScores[Ability.Constitution];
		character.TemporaryHitPoints = 0;


		character.AbilityModifier.Add(Ability.Strength, character.GetAbilityModifier(Ability.Strength));
		character.AbilityModifier.Add(Ability.Dexterity, character.GetAbilityModifier(Ability.Dexterity));
		character.AbilityModifier.Add(Ability.Intelligence, character.GetAbilityModifier(Ability.Intelligence));
		character.AbilityModifier.Add(Ability.Wisdom, character.GetAbilityModifier(Ability.Wisdom));
		character.AbilityModifier.Add(Ability.Constitution, character.GetAbilityModifier(Ability.Constitution));
		character.AbilityModifier.Add(Ability.Charisma, character.GetAbilityModifier(Ability.Charisma));


		character.SavingThrows.Add(Ability.Strength, character.GetSavingThrowBonus(Ability.Strength));
		character.SavingThrows.Add(Ability.Dexterity, character.GetSavingThrowBonus(Ability.Dexterity));
		character.SavingThrows.Add(Ability.Intelligence, character.GetSavingThrowBonus(Ability.Intelligence));
		character.SavingThrows.Add(Ability.Wisdom, character.GetSavingThrowBonus(Ability.Wisdom));
		character.SavingThrows.Add(Ability.Constitution, character.GetSavingThrowBonus(Ability.Constitution));
		character.SavingThrows.Add(Ability.Charisma, character.GetSavingThrowBonus(Ability.Charisma));

		foreach (var item in character.Skills)
		{
			Skill skill = item.Value;
			int mod = character.AbilityModifier[skill.Ability];
			skill.Modifier = mod;

			if (character.Proficiencies.Contains(skill.Type))
			{
				skill.Modifier += 2;
			}
		}

		character.ArmorClass = character.SetArmorClass();

		character.SetPassiveWisdom();

		character.AddFeat("Alert");
		character.AddFeat("Athlete");

		return character;
	}


	public static Character CreateWulfgar()
	{
		Character character = new Character();
		character.Name = "Wulfgar";
		character.Alignment = Alignment.ChaoticGood;
		character.Id = 3;


		EquipmentList.GetAllWeapons();

		character.SetRace(new Human());
		character.SetClass(new Barbarian(), 1);

		character.Inventory = character.CharacterClass.StartingEquipment;

		character.AbilityScores[Ability.Strength] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Dexterity] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Intelligence] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Wisdom] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Constitution] = Roll.InitialAbilityScore();
		character.AbilityScores[Ability.Charisma] = Roll.InitialAbilityScore();

		character.Race.AbilityScoreModifiers.ToList().ForEach(mod =>
		{
			character.AbilityScores[mod.Key] += mod.Value;
		});


		character.MaxHitPoints = character.CurrentHitPoints = character.CharacterClass.HitDie + character.AbilityScores[Ability.Constitution];
		character.TemporaryHitPoints = 0;


		character.AbilityModifier.Add(Ability.Strength, character.GetAbilityModifier(Ability.Strength));
		character.AbilityModifier.Add(Ability.Dexterity, character.GetAbilityModifier(Ability.Dexterity));
		character.AbilityModifier.Add(Ability.Intelligence, character.GetAbilityModifier(Ability.Intelligence));
		character.AbilityModifier.Add(Ability.Wisdom, character.GetAbilityModifier(Ability.Wisdom));
		character.AbilityModifier.Add(Ability.Constitution, character.GetAbilityModifier(Ability.Constitution));
		character.AbilityModifier.Add(Ability.Charisma, character.GetAbilityModifier(Ability.Charisma));


		character.SavingThrows.Add(Ability.Strength, character.GetSavingThrowBonus(Ability.Strength));
		character.SavingThrows.Add(Ability.Dexterity, character.GetSavingThrowBonus(Ability.Dexterity));
		character.SavingThrows.Add(Ability.Intelligence, character.GetSavingThrowBonus(Ability.Intelligence));
		character.SavingThrows.Add(Ability.Wisdom, character.GetSavingThrowBonus(Ability.Wisdom));
		character.SavingThrows.Add(Ability.Constitution, character.GetSavingThrowBonus(Ability.Constitution));
		character.SavingThrows.Add(Ability.Charisma, character.GetSavingThrowBonus(Ability.Charisma));

		foreach (var item in character.Skills)
		{
			Skill skill = item.Value;
			int mod = character.AbilityModifier[skill.Ability];
			skill.Modifier = mod;

			if (character.Proficiencies.Contains(skill.Type))
			{
				skill.Modifier += 2;
			}
		}

		character.ArmorClass = character.SetArmorClass();

		character.SetPassiveWisdom();

		character.AddFeat("Alert");
		character.AddFeat("Athlete");

		return character;
	}
}