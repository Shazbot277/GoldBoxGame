namespace DNDLibrary.Races;

public class Orc : RaceBase
{
	public override string Name => "Orc";
	public override string Description =>
		"Orcs are brutish, aggressive humanoids known for their strength and combat prowess.";
	public Orc()
		{
		AbilityScoreModifiers[Ability.Strength] = 2;
		AbilityScoreModifiers[Ability.Constitution] = 1;
		Languages.Add(Language.Common);
		Languages.Add(Language.Orcish);
		Traits.Add(new RacialTrait
		{
			Name = "Darkvision",
			Description = "You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Aggressive",
			Description = "As a bonus action, you can move up to your speed toward an enemy of your choice that you can see."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Menacing",
			Description = "You gain proficiency in the Intimidation skill."
		});
	}
}