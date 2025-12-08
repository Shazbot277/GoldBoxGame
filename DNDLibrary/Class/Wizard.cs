namespace DNDLibrary.Class;

public class Wizard : BaseClass
{
	public override string Name => "Wizard";
	public override int HitDie => 6;
	public override List<string> Proficiencies => new()
	{
		"Daggers",
		"Darts",
		"Slings",
		"Quarterstaffs",
		"Light Crossbows",
	};

	public override int StartingGold => 5;

	public override List<Equipment.Equipment> StartingEquipment => new()
	{
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Arcane Focus"),
		Equipment.EquipmentList.Get("Robe"),
		Equipment.EquipmentList.Get("Spellbook"),
		Equipment.EquipmentList.Get("Scholar's Pack"),
	};

	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Spellcasting",
				"Arcane Recovery"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Arcane Tradition"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Intelligence
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Intelligence,
		Ability.Wisdom
	};
}