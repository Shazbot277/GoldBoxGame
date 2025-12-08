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

	public override int StartingGold => 7;

	public override List<Equipment.Equipment> StartingEquipment => new()
	{
		Equipment.EquipmentList.Get("Studded Leather Armor"),
		Equipment.EquipmentList.Get("Scimitar"),
		Equipment.EquipmentList.Get("Shortsword"),
		Equipment.EquipmentList.Get("Longbow"),
		Equipment.EquipmentList.Get("Quiver"),
		Equipment.EquipmentList.Get("Druid Focus"),
		Equipment.EquipmentList.Get("Explorer's Pack"),
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