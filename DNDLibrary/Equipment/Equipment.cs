namespace DNDLibrary.Equipment;

public class Equipment
{
	public string Name { get; set; }
	public EquipmentType Type { get; set; }
	public int Weight { get; set; }          // In pounds
	public int Cost { get; set; }            // In gold pieces
	public string Description { get; set; }  // Optional

	public Equipment()
	{ 
	
	}
}