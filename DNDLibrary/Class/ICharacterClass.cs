namespace DNDLibrary.Class;

public interface ICharacterClass
{
    string Name { get; }

    int HitDie { get; }

	public int StartingGold { get; }

	List<string> Proficiencies { get; }

	Dictionary<int, ClassLevelFeatures> LevelFeatures { get; }

    List<Ability> PrimaryAbilities { get; }

    List<Ability> SavingThrowProficiencies { get; }

	List<Equipment.Equipment> StartingEquipment { get; }

	ClassLevelFeatures GetFeaturesForLevel(int level);
}
