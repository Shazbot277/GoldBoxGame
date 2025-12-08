namespace DNDLibrary.Class;

public class Ranger : BaseClass
{
	public override string Name => "Ranger";
	public override int HitDie => 10;
	public override List<string> Proficiencies => new()
	{
		"Simple Weapons",
		"Martial Weapons",
		"Light Armor",
		"Medium Armor",
		"Shields",
	};
	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Favored Enemy",
				"Natural Explorer"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Fighting Style",
				"Spellcasting"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Dexterity,
		Ability.Wisdom
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Strength,
		Ability.Dexterity
	};
}