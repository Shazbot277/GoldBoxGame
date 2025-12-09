namespace DNDLibrary;

public static class SkillDatabase
{
	public static readonly Dictionary<SkillType, Skill> Skills =
		new Dictionary<SkillType, Skill>
	{
		{ SkillType.Athletics, new Skill(SkillType.Athletics, Ability.Strength, "Physical feats of strength.", 0) },
		{ SkillType.Acrobatics, new Skill(SkillType.Acrobatics, Ability.Dexterity, "Balance and agility.", 0) },
		{ SkillType.SleightOfHand, new Skill(SkillType.SleightOfHand, Ability.Dexterity, "Pickpocket or palm objects.", 0) },
		{ SkillType.Stealth, new Skill(SkillType.Stealth, Ability.Dexterity, "Hide or move silently.", 0) },

		{ SkillType.Arcana, new Skill(SkillType.Arcana, Ability.Intelligence, "Knowledge of magic.", 0) },
		{ SkillType.History, new Skill(SkillType.History, Ability.Intelligence, "Lore, historical events.", 0) },
		{ SkillType.Investigation, new Skill(SkillType.Investigation, Ability.Intelligence, "Search and deduce clues.", 0) },
		{ SkillType.Nature, new Skill(SkillType.Nature, Ability.Intelligence, "Environment, plants, animals.", 0) },
		{ SkillType.Religion, new Skill(SkillType.Religion, Ability.Intelligence, "Gods, rituals, theology.", 0) },

		{ SkillType.AnimalHandling, new Skill(SkillType.AnimalHandling, Ability.Wisdom, "Interact with beasts.", 0) },
		{ SkillType.Insight, new Skill(SkillType.Insight, Ability.Wisdom, "Read motives or lies.", 0) },
		{ SkillType.Medicine, new Skill(SkillType.Medicine, Ability.Wisdom, "Stabilize or diagnose.", 0) },
		{ SkillType.Perception, new Skill(SkillType.Perception, Ability.Wisdom, "Spot hidden creatures or objects.", 0) },
		{ SkillType.Survival, new Skill(SkillType.Survival, Ability.Wisdom, "Track, forage, navigate.", 0) },

		{ SkillType.Deception, new Skill(SkillType.Deception, Ability.Charisma, "Lie or mislead.", 0) },
		{ SkillType.Intimidation, new Skill(SkillType.Intimidation, Ability.Charisma, "Coerce through threats.", 0) },
		{ SkillType.Performance, new Skill(SkillType.Performance, Ability.Charisma, "Entertain an audience.", 0) },
		{ SkillType.Persuasion, new Skill(SkillType.Persuasion, Ability.Charisma, "Influence through speech.", 0) },
	};
}
