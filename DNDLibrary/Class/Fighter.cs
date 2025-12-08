namespace DNDLibrary.Class;

public class Fighter : BaseClass
{
	public override string Name => "Fighter";
	public override int HitDie => 10;

	public override List<string> Proficiencies => new()
	{ 
		"Light Armor",
		"Shields",
		"Simple Weapons",
		"Martial Weapons"
	};

	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Fighting Style",
				"Second Wind"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Action Surge (1 use)"
			}
		}
	};

	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Strength,
		Ability.Dexterity
	};

	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Strength,
		Ability.Dexterity
	};
}