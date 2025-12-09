namespace DNDLibrary.Feats;

public static class FeatList
{
	public static List<Feat> AllFeats => GetAllFeats(); 

	private static List<Feat> GetAllFeats()
	{ 
		List<Feat> feats = new List<Feat>();
		feats.AddRange(AbilityScoreFeats);
		feats.AddRange(GeneralFeats);
		feats.AddRange(FightStyleFeats);
		return feats;
	}

	public static Feat Get(string name)
	{
		return AllFeats.FirstOrDefault(f => f.Name == name);
	}

	#region Ability Score Feats
	private static List<Feat> AbilityScoreFeats = new()
	{
		new Feat {
			Name = "Ability Score Improvement",
			Description = "Increase one ability score by 2, or two ability scores by 1.",
			GrantsAbilityIncrease = false // Implementation left to character builder UI
		},
		new Feat {
			Name = "Strength +1",
			Description = "Increase Strength by 1.",
			GrantsAbilityIncrease = true,
			AbilityIncrease = Ability.Strength,
			IncreaseAmount = 1
		},
		new Feat {
			Name = "Dexterity +1",
			Description = "Increase Dexterity by 1.",
			GrantsAbilityIncrease = true,
			AbilityIncrease = Ability.Dexterity,
			IncreaseAmount = 1
		},
		new Feat {
			Name = "Constitution +1",
			Description = "Increase Constitution by 1.",
			GrantsAbilityIncrease = true,
			AbilityIncrease = Ability.Constitution,
			IncreaseAmount = 1
		},
		new Feat {
			Name = "Intelligence +1",
			Description = "Increase Intelligence by 1.",
			GrantsAbilityIncrease = true,
			AbilityIncrease = Ability.Intelligence,
			IncreaseAmount = 1
		},
		new Feat {
			Name = "Wisdom +1",
			Description = "Ability Wisdom by 1.",
			GrantsAbilityIncrease = true,
			AbilityIncrease = Ability.Wisdom,
			IncreaseAmount = 1
		},
		new Feat {
			Name = "Charisma +1",
			Description = "Increase Charisma by 1.",
			GrantsAbilityIncrease = true,
			AbilityIncrease = Ability.Charisma,
			IncreaseAmount = 1
		},
	};

	#endregion

	#region General Feats

	private static List<Feat> GeneralFeats = new()
	{
		new Feat {
			Name = "Alert",
			Description = "You gain +5 to initiative and cannot be surprised.",
			ApplyEffect = (c) => c.InitiativeBonus += 5
		},
		new Feat {
			Name = "Athlete",
			Description = "Increase Str or Dex by 1. Climbing doesn't cost extra movement.",
			ApplyEffect = (c) => 
			{ 
				//add effect here if needed
			},
		},
		new Feat {
			Name = "Actor",
			Description = "Increase Cha by 1. Advantage on Deception and Performance when impersonating.",
		},
		new Feat {
			Name = "Charger",
			Description = "Make a melee attack as part of a Dash.",
		},
		new Feat {
			Name = "Crossbow Expert",
			Description = "No disadvantage in melee with ranged attacks; reload removed from crossbows.",
		},
		new Feat {
			Name = "Defensive Duelist",
			Description = "Reaction: add proficiency bonus to AC vs one melee attack.",
			Prerequisites = { new FeatPrerequisite { MinimumAbilityScore = 13, RequiredAbility = Ability.Dexterity } }
		},
		new Feat {
			Name = "Dual Wielder",
			Description = "Two-weapon fighting improved; +1 AC when dual wielding.",
		},
		new Feat {
			Name = "Dungeon Delver",
			Description = "Advantage on detecting secret doors, traps, and avoiding them.",
		},
		new Feat {
			Name = "Durable",
			Description = "Increase Con by 1. Minimum hit dice healing = twice modifier.",
		},
		new Feat {
			Name = "Elemental Adept",
			Description = "Damage resistance rules change for chosen element.",
		},
		new Feat {
			Name = "Grappler",
			Description = "You have advantage on attack rolls against creatures you grapple.",
		},
		new Feat {
			Name = "Healer",
			Description = "Healing kits restore additional HP.",
		},
		new Feat {
			Name = "Heavily Armored",
			Description = "Gain heavy armor proficiency; Strength +1.",
		},
		new Feat {
			Name = "Heavy Armor Master",
			Description = "Reduce non-magical weapon damage by 3.",
		},
		new Feat {
			Name = "Inspiring Leader",
			Description = "Give temp HP equal to level + Cha mod.",
		},
		new Feat {
			Name = "Keen Mind",
			Description = "Increase Int by 1; perfect recall of last month.",
		},
		new Feat {
			Name = "Lightly Armored",
			Description = "Gain light armor proficiency.",
		},
		new Feat {
			Name = "Linguist",
			Description = "Increase Int by 1; learn 3 languages.",
		},
		new Feat {
			Name = "Lucky",
			Description = "Gain 3 luck points. Reroll attack, save, or ability checks.",
		},
		new Feat {
			Name = "Mage Slayer",
			Description = "Better at fighting casters.",
		},
		new Feat {
			Name = "Magic Initiate",
			Description = "Learn 2 cantrips and 1 1st-level spell from a class list.",
		},
		new Feat {
			Name = "Martial Adept",
			Description = "Gain 1 superiority die + 2 maneuvers.",
		},
		new Feat {
			Name = "Medium Armor Master",
			Description = "No stealth penalty; Dex bonus up to +3.",
		},
		new Feat {
			Name = "Mobile",
			Description = "Speed +10ft. Ignore opportunity attacks from attacked targets.",
		},
		new Feat {
			Name = "Moderately Armored",
			Description = "Gain medium armor + shield proficiency.",
		},
		new Feat {
			Name = "Mounted Combatant",
			Description = "Advantage on mounted attacks.",
		},
		new Feat {
			Name = "Observant",
			Description = "Increase Wis or Int by 1; +5 passive Perception/Investigation.",
		},
		new Feat {
			Name = "Polearm Master",
			Description = "Bonus action with butt strike; opportunity attacks on entry.",
		},
		new Feat {
			Name = "Resilient",
			Description = "Increase one ability score by 1 and gain proficiency in its saves.",
		},
		new Feat {
			Name = "Ritual Caster",
			Description = "Learn ritual spells.",
		},
		new Feat {
			Name = "Savage Attacker",
			Description = "Once per turn reroll damage dice for melee attack.",
		},
		new Feat {
			Name = "Sentinel",
			Description = "Reduce enemy speed to 0 on opportunity hit.",
		},
		new Feat {
			Name = "Sharpshooter",
			Description = "No long range penalty; ignore half/three-quarter cover.",
			Prerequisites = { new FeatPrerequisite { MinimumAbilityScore = 13, RequiredAbility = Ability.Dexterity } }
		},
		new Feat {
			Name = "Shield Master",
			Description = "Bonus shove; Dex save bonuses with shield.",
		},
		new Feat {
			Name = "Skilled",
			Description = "Gain 3 skills or tools.",
		},
		new Feat {
			Name = "Skulker",
			Description = "Improved hiding and ranged attacks from darkness.",
		},
		new Feat {
			Name = "Spell Sniper",
			Description = "Double spell attack range; ignore cover.",
		},
		new Feat {
			Name = "Tavern Brawler",
			Description = "Increase Str or Con by 1; improvised weapons proficiency.",
		},
		new Feat {
			Name = "Tough",
			Description = "Increase HP by 2 per level.",
		},
		new Feat {
			Name = "War Caster",
			Description = "Advantage on concentration; cast spells as opportunity attacks.",
		},
		new Feat {
			Name = "Weapon Master",
			Description = "Gain proficiency in 4 martial weapons.",
		},
	};

	#endregion

	#region Fight Style Feats

	private static List<Feat> FightStyleFeats = new() 
	{
		new Feat { Name = "Fighting Style: Archery", Description = "+2 bonus to ranged attacks." },
		new Feat { Name = "Fighting Style: Defense", Description = "+1 AC while wearing armor." },
		new Feat { Name = "Fighting Style: Dueling", Description = "+2 damage with single one-handed weapon." },
		new Feat { Name = "Fighting Style: Great Weapon Fighting", Description = "Reroll 1s and 2s on 2H weapon damage dice." },
		new Feat { Name = "Fighting Style: Protection", Description = "Impose disadvantage when shielding ally." },
		new Feat { Name = "Fighting Style: Two-Weapon Fighting", Description = "Add ability modifier to off-hand damage." },
	};
	#endregion

	#region Racial Feats

	private static List<Feat> RacialFeats = new()
	{
		new Feat { Name = "Elven Accuracy", Description = "Super advantage on advantage Dex/Int/Wis/Cha attacks." },
		new Feat { Name = "Dwarven Fortitude", Description = "Con +1; heal when Dodging." },
		new Feat { Name = "Orcish Fury", Description = "Extra damage once per rest; aggressive synergy." },
		new Feat { Name = "Squat Nimbleness", Description = "Dex +1; proficiencies; speed increase." },
		new Feat { Name = "Dragon Fear", Description = "Cha/Str/Con +1; frighten nearby enemies." },
		new Feat { Name = "Dragon Hide", Description = "+1 Dex/Con; natural armor." },
	};

	#endregion

	#region 2024 Feats
	private static List<Feat> NewFeats2024 = new()
	{
		new Feat { Name = "Crafter", Description = "Discount on crafting and repair." },
		new Feat { Name = "Music Magic", Description = "Learn a musical instrument + minor magical abilities." },
		new Feat { Name = "Metamagic Adept (2024)", Description = "Gain sorcerer-style metamagic." },
		new Feat { Name = "Scion of the Outer Planes", Description = "Gain resistance + themed spell." },
		new Feat { Name = "Ritual Adept", Description = "Expanded ritual casting." },
		new Feat { Name = "Weapon Training", Description = "Learn martial weapons; class-adaptive bonuses." },
		new Feat { Name = "Teamwork Tactics", Description = "Grant allies bonuses when coordinating." },
		new Feat { Name = "Bade Performer", Description = "Musical inspiration improvements." },
		new Feat { Name = "Telepathic", Description = "Int +1 and telepathy." },
		new Feat { Name = "Telekinetic", Description = "Ability +1 and mage hand shove." },
		new Feat { Name = "Shadow-Touched", Description = "Gain Invisibility + a 1st-level spell." },
		new Feat { Name = "Fey-Touched", Description = "Gain Misty Step + a 1st-level spell." },
		new Feat { Name = "Gift of the Chromatic Dragon", Description = "Elemental damage and resistance options." },
		new Feat { Name = "Gift of the Metallic Dragon", Description = "Shield spell + healing." },
		new Feat { Name = "Gift of the Gem Dragon", Description = "Wis/Int/Cha +1; telekinetic retaliation." },


	};
	#endregion




}
