using DNDLibrary.Equipment;
using System.Drawing;

namespace DNDLibrary.Races;

public class DraconicAncestry
{
	public DragonType Color { get; set; }

	public DamageType DamageType { get; set; }

	public DraconicAncestry()
	{ 
	
	}

	public static List<DraconicAncestry> List = new()
	{
		new DraconicAncestry { Color = DragonType.Black, DamageType = DamageType.Acid },
		new DraconicAncestry { Color = DragonType.Blue, DamageType = DamageType.Lightning },
		new DraconicAncestry { Color = DragonType.Brass, DamageType = DamageType.Fire },
		new DraconicAncestry { Color = DragonType.Bronze, DamageType = DamageType.Lightning },
		new DraconicAncestry { Color = DragonType.Copper, DamageType = DamageType.Acid },
		new DraconicAncestry { Color = DragonType.Gold, DamageType = DamageType.Fire },
		new DraconicAncestry { Color = DragonType.Green, DamageType = DamageType.Poison },
		new DraconicAncestry { Color = DragonType.Red, DamageType = DamageType.Fire },
		new DraconicAncestry { Color = DragonType.Silver, DamageType = DamageType.Cold },
		new DraconicAncestry { Color = DragonType.White, DamageType = DamageType.Cold }
	};

	public static DraconicAncestry Get(DragonType color)
	{
		return List.Where(x => x.Color == color).FirstOrDefault();
	}

	public enum DragonType
	{
		Black,
		Blue,
		Brass,
		Bronze,
		Copper,
		Gold,
		Green,
		Red,
		Silver,
		White
	}
}
