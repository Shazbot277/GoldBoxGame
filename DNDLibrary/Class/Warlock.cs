namespace DNDLibrary.Class;

public class Warlock : BaseClass
{
	public override string Name => "Warlock";
	public override int HitDie => 8;
	public override List<string> Proficiencies => new()
	{
		"Simple Weapons",
	};
	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Otherworldly Patron",
				"Pact Magic"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Eldritch Invocations"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Charisma
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Wisdom,
		Ability.Charisma
	};
}