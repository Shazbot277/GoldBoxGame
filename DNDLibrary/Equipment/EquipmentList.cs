namespace DNDLibrary.Equipment;

public static class EquipmentList
{
	public static List<Equipment> All = new List<Equipment>()
	{
        // Weapons
        new Weapon() {
			Name = "Club",
			Type = EquipmentType.Weapon,
			Category = WeaponCategory.Simple,
			DiceCount = 1, DiceSides = 4,
			DamageType = WeaponDamageType.Bludgeoning,
			TwoHanded = false,
			Weight = 2,
			Cost = 1
		},

		new Weapon() {
			Name = "Longsword",
			Type = EquipmentType.Weapon,
			Category = WeaponCategory.Martial,
			DiceCount = 1, DiceSides = 8,
			DamageType = WeaponDamageType.Slashing,
			TwoHanded = false,
			Weight = 3,
			Cost = 15
		},

        // Armor
        new Armor() {
			Name = "Leather Armor",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Light,
			BaseAC = 11,
			AddDexModifier = true,
			Weight = 10,
			Cost = 10
		},

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