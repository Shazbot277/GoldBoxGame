namespace DNDLibrary.Races;

public class HillDwarf : Dwarf
{
	public override string Name => "Hill Dwarf";
	public override string Description => "As a hill dwarf, you have keen senses, deep intuition, and remarkable resilience.";
	public HillDwarf()
	{
		AbilityScoreModifiers[Ability.Constitution] = 1;
		Traits.Add(new RacialTrait
		{
			Name = "Dwarven Toughness",
			Description = "Your Hit Point maximum increases by 1, and it increases by 1 again whenever you gain a level."
		});
	}
}