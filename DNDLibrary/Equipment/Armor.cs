namespace DNDLibrary.Equipment;

public class Armor : Equipment
{
	public ArmorCategory Category { get; set; }
	public int BaseAC { get; set; }
	public bool AddDexModifier { get; set; } = true;
	public int MaxDexBonus { get; set; } = int.MaxValue; // unlimited unless medium armor


	public static List<Armor> All = new List<Armor>() 
	{
		new Armor() {
			Name = "Padded Armor",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Light,
			BaseAC = 11,
			AddDexModifier = true,
			Weight = 8,
			Cost = 5
		},
		new Armor() {
			Name = "Leather",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Light,
			BaseAC = 11,
			AddDexModifier = true,
			Weight = 10,
			Cost = 10
		},
		new Armor() {
			Name = "Studded Leather Armor",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Light,
			BaseAC = 12,
			AddDexModifier = true,
			Weight = 13,
			Cost = 45,
			MaxDexBonus = 2

		},
		new Armor() {
			Name = "Hide",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Medium,
			BaseAC = 12,
			AddDexModifier = true,
			Weight = 12,
			Cost = 10,
			MaxDexBonus = 2
		},
		new Armor() {
			Name = "Chain Shirt",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Medium,
			BaseAC = 13,
			AddDexModifier = true,
			Weight = 20,
			Cost = 50,
			MaxDexBonus = 2
		},
		new Armor() {
			Name = "Scale Mail",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Medium,
			BaseAC = 14,
			AddDexModifier = true,
			Weight = 45,
			Cost = 50,
			MaxDexBonus = 2
		},
		new Armor() {
			Name = "Breast Plate",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Medium,
			BaseAC = 14,
			AddDexModifier = true,
			Weight = 20,
			Cost = 400,
			MaxDexBonus = 2
		},
		new Armor() {
			Name = "Half Plate",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Medium,
			BaseAC = 15,
			AddDexModifier = true,
			Weight = 40,
			Cost = 750,
			MaxDexBonus = 2
		},
		new Armor() {
			Name = "Ring Mail",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Heavy,
			BaseAC = 14,
			AddDexModifier = false,
			Weight = 40,
			Cost = 30
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
			Name = "Splint Mail",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Heavy,
			BaseAC = 17,
			AddDexModifier = false,
			Weight = 60,
			Cost = 200
		},
		new Armor() {
			Name = "Plate",
			Type = EquipmentType.Armor,
			Category = ArmorCategory.Heavy,
			BaseAC = 18,
			AddDexModifier = false,
			Weight = 65,
			Cost = 1500
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
		new Armor() {
			Name = "Tower Shield",
			Type = EquipmentType.Shield,
			Category = ArmorCategory.Shield,
			BaseAC = 3,
			AddDexModifier = false,
			Weight = 45,
			Cost = 10
		},

        // Gear
   //     new Equipment() {
			//Name = "Backpack",
			//Type = EquipmentType.Gear,
			//Weight = 5,
			//Cost = 2,
			//Description = "A durable pack for carrying supplies."
		//}

	};
}