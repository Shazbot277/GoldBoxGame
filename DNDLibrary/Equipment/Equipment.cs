namespace DNDLibrary.Equipment;

public class Equipment
{
	public string Name { get; set; }
	public EquipmentType Type { get; set; }
	public int Weight { get; set; }          // In pounds
	public int Cost { get; set; }            // In gold pieces
	public string Description { get; set; }  // Optional
	public CharacterBodyPart BodyPart { get; set; }
	public bool IsEquipped { get; set; } = false;


	public Equipment()
	{ 
	
	}
}

public enum CharacterBodyPart
{ 
	Head,
	MainHand,
	OffHand,
	Body
}