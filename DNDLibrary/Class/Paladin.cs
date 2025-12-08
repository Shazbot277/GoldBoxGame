namespace DNDLibrary.Class;

public class Paladin : BaseClass
{
	public override string Name => "Paladin";
	public override int HitDie => 10;
	public override List<string> Proficiencies => new()
	{
		"Simple Weapons",
		"Martial Weapons",
		"Light Armor",
		"Medium Armor",
		"Shields"
	};

	public override int StartingGold => 9;

	public override List<Equipment.Equipment> StartingEquipment => new()
	{
		Equipment.EquipmentList.Get("Chain Mail"),
		Equipment.EquipmentList.Get("Shield"),
		Equipment.EquipmentList.Get("Longsword"),
		Equipment.EquipmentList.Get("Javelin"),
		Equipment.EquipmentList.Get("Javelin"),
		Equipment.EquipmentList.Get("Javelin"),
		Equipment.EquipmentList.Get("Javelin"),
		Equipment.EquipmentList.Get("Javelin"),
		Equipment.EquipmentList.Get("Javelin"),
		Equipment.EquipmentList.Get("Holy Symbol"),
		Equipment.EquipmentList.Get("Priest's Pack"),
	};

	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Divine Sense",
				"Lay on Hands"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Sacred Oath"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Strength,
		Ability.Charisma
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Wisdom,
		Ability.Charisma
	};
}
