namespace DNDLibrary.Equipment;

public static class EquipmentList
{
	public static void GetAllWeapons()
	{
		All.AddRange(Weapons.All);
	}

	public static List<Equipment> All = new List<Equipment>()
	{
		new Armor() {
			Name = "Chain Mail",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Heavy,
			BaseAC = 16,
			AddDexModifier = false,
			Weight = 55,
			Cost = 75
		},

		new Armor() {
			Name = "Shield",
			Type = EquipmentType.Shield,
			Category = ArmorCategory.Shield,
			BaseAC = 2,
			AddDexModifier = false,
			Weight = 6,
			Cost = 10
		},

        // Gear
        new Equipment() {
			Name = "Backpack",
			Type = EquipmentType.Gear,
			Weight = 5,
			Cost = 2,
			Description = "A durable pack for carrying supplies."
		}
	};

	public static Equipment Get(string name)
		=> All.FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
}