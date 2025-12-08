namespace DNDLibrary.Class;

public abstract class BaseClass : ICharacterClass
{
	public abstract string Name { get; }
	public abstract int HitDie { get; }
	public abstract List<string> Proficiencies { get; }
	public abstract Dictionary<int, ClassLevelFeatures> LevelFeatures { get; }

	public abstract List<Ability> PrimaryAbilities { get; }

	public abstract List<Ability> SavingThrowProficiencies { get; }

	public ClassLevelFeatures GetFeaturesForLevel(int level)
	{
		return LevelFeatures.ContainsKey(level)
			? LevelFeatures[level]
			: null;
	}
}
