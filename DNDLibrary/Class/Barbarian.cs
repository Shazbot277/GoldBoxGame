namespace DNDLibrary.Class;

public class Barbarian : BaseClass
{
	public override string Name => "Barbarian";
	public override int HitDie => 12;
	public override List<string> Proficiencies => new()
	{
		"Light Armor",
		"Medium Armor",
		"Shields",
		"Simple Weapons",
		"Martial Weapons",
	};
	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Rage",
				"Unarmored Defense"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Reckless Attack",
				"Danger Sense"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Strength,
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Strength,
		Ability.Constitution
	};
}
