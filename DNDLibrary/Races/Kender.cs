namespace DNDLibrary.Races;

public class Kender : RaceBase
{
	public override string Name => "Kender";
	public override string Description =>
		"Kender are a curious and adventurous race known for their fearless nature and knack for getting into trouble.";
	public Kender()
	{
		AbilityScoreModifiers[Ability.Dexterity] = 2;
		AbilityScoreModifiers[Ability.Charisma] = 1;
		Languages.Add(Language.Common);
		Languages.Add(Language.Halfling);
		Traits.Add(new RacialTrait
		{
			Name = "Fearless",
			Description = "You have advantage on saving throws against being frightened."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Kender Agility",
			Description = "You can move through the space of any creature that is of a size larger than yours."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Curious Nature",
			Description = "You have proficiency in the Investigation skill."
		});
	}
}