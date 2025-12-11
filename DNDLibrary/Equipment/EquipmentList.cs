namespace DNDLibrary.Equipment;

public static class EquipmentList
{
	public static void GetAllWeapons()
	{
		All.AddRange(Weapons.All);
	}

	public static List<Equipment> All => GetAll();

	public static List<Equipment> GetAll()
	{
		List<Equipment> equipment = new List<Equipment>();
		equipment.AddRange(Weapons.All);
		equipment.AddRange(Armor.All);
		return equipment;
	}


	public static Equipment Get(string name)
		=> All.FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
}