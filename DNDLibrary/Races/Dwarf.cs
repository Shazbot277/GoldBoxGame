namespace DNDLibrary.Races;

public class Dwarf : RaceBase
{
	public override string Name => "Dwarf";
	public override string Description => "Dwarves were raised from the earth in the elder days by a deity of the forge";
	public Dwarf()
	{
		AbilityScoreModifiers[Ability.Dexterity] = 2;

		Languages.Add(Language.Dwarvish);

		Traits.Add(new RacialTrait
		{
			Name = "DarkVision",
			Description = "You have Darkvision with a range of 120 feet."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Dwarven Resilience",
			Description = "You have Resistance to Poison damage. You also have Advantage on saving throws you make to avoid or end the Poisoned condition."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Dwarven Toughness",
			Description = "Your Hit Point maximum increases by 1, and it increases by 1 again whenever you gain a level."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Stonecunning",
			Description = "As a Bonus Action, you gain Tremorsense with a range of 60 feet for 10 minutes. You must be on a stone surface or touching a stone surface to use this Tremorsense. The stone can be natural or worked.\r\n\r\nYou can use this Bonus Action a number of times equal to your Proficiency Bonus, and you regain all expended uses when you finish a Long Rest."
		});
	}
}