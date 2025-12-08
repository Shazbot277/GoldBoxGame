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

	public override int StartingGold => 7;

	public override List<Equipment.Equipment> StartingEquipment => new()
	{
		Equipment.EquipmentList.Get("Chain Shirt"),
		Equipment.EquipmentList.Get("Shield"),
		Equipment.EquipmentList.Get("Mace"),
		Equipment.EquipmentList.Get("Holy Symbol"),
		Equipment.EquipmentList.Get("Priet's Pack"),
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
