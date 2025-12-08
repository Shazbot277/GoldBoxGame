namespace DNDLibrary.Class;

public class Fighter : BaseClass
{
	public override string Name => "Fighter";
	public override int HitDie => 10;
	public override List<string> Proficiencies => new()
	{
		"All Armor",
		"Shields",
		"Simple Weapons",
		"Martial Weapons",
	};


	public override int StartingGold => 0; // Fighters do not start with gold if using standard starting equipment

	public override List<Equipment.Equipment> StartingEquipment => new()
	{
		Equipment.EquipmentList.Get("Chain Mail"),
		Equipment.EquipmentList.Get("Longsword"),
		Equipment.EquipmentList.Get("Shield"),
		Equipment.EquipmentList.Get("Light Crossbow"),
		Equipment.EquipmentList.Get("20 Bolts"),
		Equipment.EquipmentList.Get("Explorer's Pack")
	};

	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Fighting Style",
				"Second Wind"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Action Surge"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Strength,
		Ability.Dexterity
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Strength,
		Ability.Constitution
	};
}