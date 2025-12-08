namespace DNDLibrary.Class;

public class Monk : BaseClass
{
	public override string Name => "Monk";
	public override int HitDie => 8;
	public override List<string> Proficiencies => new()
	{
		"Simple Weapons",
		"Shortswords",
	};

	public override int StartingGold => 11;

	public override List<Equipment.Equipment> StartingEquipment => new()
	{
		Equipment.EquipmentList.Get("Spear"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Explorer's Pack"),
	};

	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Unarmored Defense",
				"Martial Arts"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Ki",
				"Unarmored Movement"
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
