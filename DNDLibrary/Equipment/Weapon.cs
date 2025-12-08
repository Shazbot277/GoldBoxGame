namespace DNDLibrary.Equipment;

public class Weapon : Equipment
{
	public WeaponCategory Category { get; set; }
	public int DiceCount { get; set; }
	public int DiceSides { get; set; }
	public WeaponDamageType DamageType { get; set; }
	public bool TwoHanded { get; set; }
}