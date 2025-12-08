namespace DNDLibrary.Races;

public class Halfling : RaceBase
{
	public override string Name => "Halfling";
	public override string Description =>
		"Halflings are a diminutive people, about 3 feet tall. They are known for their cheerful demeanor and resourcefulness.";
	public Halfling()
		{
		AbilityScoreModifiers[Ability.Dexterity] = 2;
		Languages.Add(Language.Common);
		Languages.Add(Language.Halfling);
		Traits.Add(new RacialTrait
		{
			Name = "Lucky",
			Description = "When you roll a 1 on the d20 for an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Brave",
			Description = "You have advantage on saving throws against being frightened."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Halfling Nimbleness",
			Description = "You can move through the space of any creature that is of a size larger than yours."
		});
	}
}