namespace DNDLibrary;

public class Skill
{
	public SkillType Type { get; set; }
	public Ability Ability { get; set; }
	public string Description { get; set; }
	public int Modifier { get; set; }

	public Skill(SkillType type, Ability ability, string description, int modifier)
	{
		Type = type;
		Ability = ability;
		Description = description;
		Modifier = modifier;
	}
}