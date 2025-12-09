namespace DNDLibrary.Feats;

public class FeatPrerequisite
{
	public Ability? RequiredAbility { get; set; }
	public int MinimumAbilityScore { get; set; } = 0;

	public string? RequiredRace { get; set; } = null;
	public string? RequiredClass { get; set; } = null;
	public int MinimumLevel { get; set; } = 0;

	public string? RequiredFeat { get; set; } = null;

	public bool Meets(Character character)
	{
		if (RequiredAbility != null)
		{
			int score = character.GetAbilityScore(RequiredAbility.Value);
			if (score < MinimumAbilityScore) return false;
		}

		if (RequiredRace != null && character.Race.Name != RequiredRace)
			return false;

		if (RequiredClass != null && character.CharacterClass.Name != RequiredClass)
			return false;

		if (character.Level < MinimumLevel)
			return false;

		if (RequiredFeat != null && !character.Feats.Contains(RequiredFeat))
			return false;

		return true;
	}
}