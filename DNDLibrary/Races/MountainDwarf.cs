namespace DNDLibrary.Races;

public class MountainDwarf : Dwarf
{
	public override string Name => "Mountain Dwarf";
	public override string Description => "Mountain Dwarves are strong and hardy, accustomed to a difficult life in rugged terrain.";
	public MountainDwarf()
	{
		AbilityScoreModifiers[Ability.Strength] = 2;

		Traits.Add(new RacialTrait
		{
			Name = "Dwarven Armor Training",
			Description = "You have proficiency with light armor and medium armor."
		});

	}

}
