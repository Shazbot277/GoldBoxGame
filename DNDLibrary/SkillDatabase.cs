namespace DNDLibrary;

public static class SkillDatabase
{
	public static readonly Dictionary<SkillType, Skill> Skills =
		new Dictionary<SkillType, Skill>
	{
		{ SkillType.Athletics, new Skill(SkillType.Athletics, Ability.Strength, "Physical feats of strength.") },
		{ SkillType.Acrobatics, new Skill(SkillType.Acrobatics, Ability.Dexterity, "Balance and agility.") },
		{ SkillType.SleightOfHand, new Skill(SkillType.SleightOfHand, Ability.Dexterity, "Pickpocket or palm objects.") },
		{ SkillType.Stealth, new Skill(SkillType.Stealth, Ability.Dexterity, "Hide or move silently.") },

		{ SkillType.Arcana, new Skill(SkillType.Arcana, Ability.Intelligence, "Knowledge of magic.") },
		{ SkillType.History, new Skill(SkillType.History, Ability.Intelligence, "Lore, historical events.") },
		{ SkillType.Investigation, new Skill(SkillType.Investigation, Ability.Intelligence, "Search and deduce clues.") },
		{ SkillType.Nature, new Skill(SkillType.Nature, Ability.Intelligence, "Environment, plants, animals.") },
		{ SkillType.Religion, new Skill(SkillType.Religion, Ability.Intelligence, "Gods, rituals, theology.") },

		{ SkillType.AnimalHandling, new Skill(SkillType.AnimalHandling, Ability.Wisdom, "Interact with beasts.") },
		{ SkillType.Insight, new Skill(SkillType.Insight, Ability.Wisdom, "Read motives or lies.") },
		{ SkillType.Medicine, new Skill(SkillType.Medicine, Ability.Wisdom, "Stabilize or diagnose.") },
		{ SkillType.Perception, new Skill(SkillType.Perception, Ability.Wisdom, "Spot hidden creatures or objects.") },
		{ SkillType.Survival, new Skill(SkillType.Survival, Ability.Wisdom, "Track, forage, navigate.") },

		{ SkillType.Deception, new Skill(SkillType.Deception, Ability.Charisma, "Lie or mislead.") },
		{ SkillType.Intimidation, new Skill(SkillType.Intimidation, Ability.Charisma, "Coerce through threats.") },
		{ SkillType.Performance, new Skill(SkillType.Performance, Ability.Charisma, "Entertain an audience.") },
		{ SkillType.Persuasion, new Skill(SkillType.Persuasion, Ability.Charisma, "Influence through speech.") },
	};
}
