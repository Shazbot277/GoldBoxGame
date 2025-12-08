namespace DNDLibrary;

public class Skill
{
	public SkillType Type { get; set; }
	public Ability Ability { get; set; }
	public string Description { get; set; }

	public Skill(SkillType type, Ability ability, string description)
	{
		Type = type;
		Ability = ability;
		Description = description;
	}
}