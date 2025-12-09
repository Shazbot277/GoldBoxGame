namespace DNDLibrary.Feats;

public class Feat
{
	public string Name { get; set; }
	public string Description { get; set; }

	public bool GrantsAbilityIncrease { get; set; } = false;
	public Ability? AbilityIncrease { get; set; }
	public int IncreaseAmount { get; set; } = 0;

	public List<FeatPrerequisite> Prerequisites { get; set; } = new();

	public Action<Character> ApplyEffect { get; set; } = (c) => { };

	public bool CanTake(Character character)
	{
		foreach (var p in Prerequisites)
		{
			if (!p.Meets(character))
				return false;
		}
		return true;
	}
}	