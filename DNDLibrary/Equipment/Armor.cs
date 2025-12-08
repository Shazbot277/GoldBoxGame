namespace DNDLibrary.Equipment;

public class Armor : Equipment
{
	public ArmorCategory Category { get; set; }
	public int BaseAC { get; set; }
	public bool AddDexModifier { get; set; } = true;
	public int MaxDexBonus { get; set; } = int.MaxValue; // unlimited unless medium armor
}