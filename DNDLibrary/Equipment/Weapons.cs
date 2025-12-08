using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDLibrary.Equipment;

public static class Weapons
{
	public static Weapon Get(string name)
	=> All.FirstOrDefault(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));


	public static List<Weapon> All = new List<Weapon>()
	{
        // -------------------------
        // SIMPLE MELEE
        // -------------------------
        new Weapon {
		Name="Club", Type=EquipmentType.Weapon,
		Category=WeaponCategory.Simple,
		DamageType=WeaponDamageType.Bludgeoning,
		DiceCount=1, DiceSides=4,
		Properties={ WeaponProperty.Light },
		Weight=2, Cost=1
	},

		new Weapon {
			Name="Dagger", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=4,
			Properties={ WeaponProperty.Finesse, WeaponProperty.Light, WeaponProperty.Thrown },
			RangeNormal=20, RangeLong=60,
			Weight=1, Cost=2
		},

		new Weapon {
			Name="Greatclub", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Bludgeoning,
			DiceCount=1, DiceSides=8,
			Properties={ WeaponProperty.TwoHanded },
			Weight=10, Cost=2
		},

		new Weapon {
			Name="Handaxe", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=1, DiceSides=6,
			Properties={ WeaponProperty.Light, WeaponProperty.Thrown },
			RangeNormal=20, RangeLong=60,
			Weight=2, Cost=5
		},

		new Weapon {
		Name="Javelin", Type=EquipmentType.Weapon,
		Category=WeaponCategory.Simple,
		DamageType=WeaponDamageType.Piercing,
		DiceCount=1, DiceSides=6,
		Properties={ WeaponProperty.Thrown },
		RangeNormal=30, RangeLong=120,
		Weight=2, Cost=5
	},

		new Weapon {
			Name="Light Hammer", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Bludgeoning,
			DiceCount=1, DiceSides=4,
			Properties={ WeaponProperty.Light, WeaponProperty.Thrown },
			RangeNormal=20, RangeLong=60,
			Weight=2, Cost=2
		},

		new Weapon {
			Name="Mace", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Bludgeoning,
			DiceCount=1, DiceSides=6,
			Weight=4, Cost=5
		},

		new Weapon {
			Name="Quarterstaff", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Bludgeoning,
			DiceCount=1, DiceSides=6,
			VersatileDiceSides=8,
			Properties={ WeaponProperty.Versatile },
			Weight=4, Cost=2
		},

		new Weapon {
			Name="Sickle", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=1, DiceSides=4,
			Properties={ WeaponProperty.Light },
			Weight=2, Cost=1
		},

		new Weapon {
			Name="Spear", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=6,
			VersatileDiceSides=8,
			Properties={ WeaponProperty.Thrown, WeaponProperty.Versatile },
			RangeNormal=20, RangeLong=60,
			Weight=3, Cost=1
		},

			// -------------------------
			// SIMPLE RANGED
			// -------------------------
			new Weapon {
			Name="Light Crossbow", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=8,
			Properties={ WeaponProperty.Ammunition, WeaponProperty.Loading, WeaponProperty.TwoHanded },
			RangeNormal=80, RangeLong=320,
			Weight=5, Cost=25
		},

		new Weapon {
			Name="Dart", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=4,
			Properties={ WeaponProperty.Finesse, WeaponProperty.Thrown },
			RangeNormal=20, RangeLong=60,
			Weight=0, Cost=0
		},

		new Weapon {
			Name="Shortbow", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=6,
			Properties={ WeaponProperty.Ammunition, WeaponProperty.TwoHanded },
			RangeNormal=80, RangeLong=320,
			Weight=2, Cost=25
		},

		new Weapon {
			Name="Sling", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Simple,
			DamageType=WeaponDamageType.Bludgeoning,
			DiceCount=1, DiceSides=4,
			Properties={ WeaponProperty.Ammunition },
			RangeNormal=30, RangeLong=120,
			Weight=0, Cost=1
		},

			// -------------------------
			// MARTIAL MELEE
			// -------------------------
			new Weapon {
			Name="Battleaxe", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=1, DiceSides=8,
			VersatileDiceSides=10,
			Properties={ WeaponProperty.Versatile },
			Weight=4, Cost=10
		},

		new Weapon {
			Name="Flail", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Bludgeoning,
			DiceCount=1, DiceSides=8,
			Weight=2, Cost=10
		},

		new Weapon {
			Name="Glaive", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=1, DiceSides=10,
			Properties={ WeaponProperty.Heavy, WeaponProperty.Reach, WeaponProperty.TwoHanded },
			Weight=6, Cost=20
		},

		new Weapon {
			Name="Greataxe", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=1, DiceSides=12,
			Properties={ WeaponProperty.Heavy, WeaponProperty.TwoHanded },
			Weight=7, Cost=30
		},

		new Weapon {
			Name="Greatsword", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=2, DiceSides=6,
			Properties={ WeaponProperty.Heavy, WeaponProperty.TwoHanded },
			Weight=6, Cost=50
		},

		new Weapon {
			Name="Halberd", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=1, DiceSides=10,
			Properties={ WeaponProperty.Heavy, WeaponProperty.Reach, WeaponProperty.TwoHanded },
			Weight=6, Cost=20
		},

		new Weapon {
			Name="Lance", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=12,
			Properties={ WeaponProperty.Reach, WeaponProperty.Special },
			Weight=6, Cost=10
		},

		new Weapon {
			Name="Longsword", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=1, DiceSides=8,
			VersatileDiceSides=10,
			Properties={ WeaponProperty.Versatile },
			Weight=3, Cost=15
		},

		new Weapon {
			Name="Maul", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Bludgeoning,
			DiceCount=2, DiceSides=6,
			Properties={ WeaponProperty.Heavy, WeaponProperty.TwoHanded },
			Weight=10, Cost=10
		},

		new Weapon {
			Name="Morningstar", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=8,
			Weight=4, Cost=15
		},

		new Weapon {
			Name="Pike", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=10,
			Properties={ WeaponProperty.Heavy, WeaponProperty.Reach, WeaponProperty.TwoHanded },
			Weight=18, Cost=5
		},

		new Weapon {
			Name="Rapier", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=8,
			Properties={ WeaponProperty.Finesse },
			Weight=2, Cost=25
		},

		new Weapon {
			Name="Scimitar", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=1, DiceSides=6,
			Properties={ WeaponProperty.Finesse, WeaponProperty.Light },
			Weight=3, Cost=25
		},

		new Weapon {
			Name="Shortsword", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=6,
			Properties={ WeaponProperty.Finesse, WeaponProperty.Light },
			Weight=2, Cost=10
		},

		new Weapon {
			Name="Trident", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=6,
			VersatileDiceSides=8,
			Properties={ WeaponProperty.Thrown, WeaponProperty.Versatile },
			RangeNormal=20, RangeLong=60,
			Weight=4, Cost=5
		},

		new Weapon {
			Name="War Pick", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=8,
			Weight=2, Cost=5
		},

		new Weapon {
			Name="Warhammer", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Bludgeoning,
			DiceCount=1, DiceSides=8,
			VersatileDiceSides=10,
			Properties={ WeaponProperty.Versatile },
			Weight=2, Cost=15
		},

		new Weapon {
			Name="Whip", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Slashing,
			DiceCount=1, DiceSides=4,
			Properties={ WeaponProperty.Finesse, WeaponProperty.Reach },
			Weight=3, Cost=2
		},

			// -------------------------
			// MARTIAL RANGED
			// -------------------------
			new Weapon {
			Name="Blowgun", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=1,
			Properties={ WeaponProperty.Ammunition, WeaponProperty.Loading },
			RangeNormal=25, RangeLong=100,
			Weight=1, Cost=10
		},

		new Weapon {
			Name="Hand Crossbow", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=6,
			Properties={ WeaponProperty.Ammunition, WeaponProperty.Light, WeaponProperty.Loading },
			RangeNormal=30, RangeLong=120,
			Weight=3, Cost=75
		},

		new Weapon {
			Name="Heavy Crossbow", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=10,
			Properties={ WeaponProperty.Ammunition, WeaponProperty.Heavy, WeaponProperty.Loading, WeaponProperty.TwoHanded },
			RangeNormal=100, RangeLong=400,
			Weight=18, Cost=50
		},

		new Weapon {
			Name="Longbow", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Piercing,
			DiceCount=1, DiceSides=8,
			Properties={ WeaponProperty.Ammunition, WeaponProperty.Heavy, WeaponProperty.TwoHanded },
			RangeNormal=150, RangeLong=600,
			Weight=2, Cost=50
		},

		new Weapon {
			Name="Net", Type=EquipmentType.Weapon,
			Category=WeaponCategory.Martial,
			DamageType=WeaponDamageType.Bludgeoning,
			DiceCount=0, DiceSides=0,
			Properties={ WeaponProperty.Special, WeaponProperty.Thrown },
			RangeNormal=5, RangeLong=15,
			Weight=3, Cost=1
		}
	};
}
