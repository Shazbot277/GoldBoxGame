namespace DNDLibrary.Class;

public class Druid : BaseClass
{
	public override string Name => "Druid";
	public override int HitDie => 8;
	public override List<string> Proficiencies => new()
	{
		"Light Armor",
		"Medium Armor",
		"Shields",
		"Clubs",
		"Daggers",
		"Darts",
		"Javelins",
		"Maces",
		"Quarterstaffs",
		"Sickles",
		"Slings",
		"Spears",
	};

	public override int StartingGold => 9;

	public override List<Equipment.Equipment> StartingEquipment => new()
	{
		Equipment.EquipmentList.Get("Leather Armor"),
		Equipment.EquipmentList.Get("Shield"),
		Equipment.EquipmentList.Get("Sickle"),
		Equipment.EquipmentList.Get("Druidic Focus (Quarter Staff("),
		Equipment.EquipmentList.Get("Explorer's Pack"),
		Equipment.EquipmentList.Get("Herbalism Kit"),
	};

	public override Dictionary<int, ClassLevelFeatures> LevelFeatures => new()
	{
		[1] = new ClassLevelFeatures
		{
			Level = 1,
			Features = new()
			{
				"Spellcasting",
				"Druidic"
			}
		},
		[2] = new ClassLevelFeatures
		{
			Level = 2,
			Features = new()
			{
				"Wild Shape"
			}
		}
	};
	public override List<Ability> PrimaryAbilities => new()
	{
		Ability.Wisdom
	};
	public override List<Ability> SavingThrowProficiencies => new()
	{
		Ability.Intelligence,
		Ability.Wisdom
	};
}
