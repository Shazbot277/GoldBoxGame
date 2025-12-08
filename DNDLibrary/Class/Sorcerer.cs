namespace DNDLibrary.Class;

public class Sorcerer : BaseClass
{
	public override string Name => "Sorcerer";
	public override int HitDie => 6;
	public override List<string> Proficiencies => new()
	{
		"Daggers",
		"Darts",
		"Slings",
		"Quarterstaffs",
		"Light Crossbows",
	};
	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Spellcasting",
				"Sorcerous Origin"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Sorcery Points"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Charisma
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Constitution,
		Ability.Charisma
	};
}
