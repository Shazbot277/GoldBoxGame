namespace DNDLibrary.Class;

public class Bard : BaseClass
{
	public override string Name => "Bard";
	public override int HitDie => 8;
	public override List<string> Proficiencies => new()
	{
		"Light Armor",
		"Simple Weapons",
		"Hand Crossbows",
		"Longswords",
		"Rapiers",
		"Shortswords",
		"Three Musical Instruments"
	};
	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Spellcasting",
				"Bardic Inspiration"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Jack of All Trades",
				"Song of Rest"
			}
		}
	};

	public override int StartingGold => 19;

	public override List<Equipment.Equipment> StartingEquipment => new()
	{
		Equipment.EquipmentList.Get("Leather Armor"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Entertainer’s Pack"),
	};

	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Charisma
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Dexterity,
		Ability.Charisma
	};
}