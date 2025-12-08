namespace DNDLibrary.Class;

public class Rogue : BaseClass
{
	public override string Name => "Rogue";
	public override int HitDie => 8;
	public override List<string> Proficiencies => new()
	{
		"Simple Weapons",
		"Hand Crossbows",
		"Longswords",
		"Rapiers",
		"Shortswords",
	};

	public override int StartingGold => 8;

	public override List<Equipment.Equipment> StartingEquipment => new()
	{
		Equipment.EquipmentList.Get("Leather Armor"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Dagger"),
		Equipment.EquipmentList.Get("Longbow"),
		Equipment.EquipmentList.Get("Quiver"),
		Equipment.EquipmentList.Get("Theives' Tools"),
		Equipment.EquipmentList.Get("Burglar's Pack"),
	};

	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Sneak Attack",
				"Thieves' Cant"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Cunning Action"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Dexterity
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Dexterity,
		Ability.Intelligence
	};
}