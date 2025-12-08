namespace DNDLibrary.Equipment;

public class Weapon : Equipment
{
	public WeaponCategory Category { get; set; }
	public WeaponDamageType DamageType { get; set; }


	public int DiceCount { get; set; }

	public int DiceSides { get; set; }
	
	public bool TwoHanded { get; set; }


	public List<WeaponProperty> Properties { get; set; } = new List<WeaponProperty>();

	public int?RangeNormal { get; set; }
	public int?RangeLong { get; set; }

	public int?VersatileDiceSides { get; set; } //For 1d10

}