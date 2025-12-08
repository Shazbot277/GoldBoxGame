namespace DNDLibrary.Class;

public interface ICharacterClass
{
    string Name { get; }
    int HitDie { get; }
    List<string> Proficiencies { get; }
	Dictionary<int, ClassLevelFeatures> LevelFeatures { get; }

    List<Ability> PrimaryAbilities { get; }

    List<Ability> SavingThrowProficiencies { get; }

	ClassLevelFeatures GetFeaturesForLevel(int level);
}
