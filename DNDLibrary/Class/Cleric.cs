namespace DNDLibrary.Class;

public class Cleric : BaseClass
{
	public override string Name => "Cleric";
	public override int HitDie => 8;
	public override List<string> Proficiencies => new()
	{
		"Light Armor",
		"Medium Armor",
		"Shields",
		"Simple Weapons",
	};
	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Spellcasting",
				"Divine Domain"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Channel Divinity (1/rest)"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Wisdom
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Wisdom,
		Ability.Charisma
	};

}
