namespace DNDLibrary.Races;

public class Gnome : RaceBase
{
	public override string Name => "Gnome";
	public override string Description => "Inventive and curious beings";
	public Gnome()
	{
		AbilityScoreModifiers[Ability.Intelligence] = 2;

		Languages.Add(Language.Common);
		Languages.Add(Language.Gnomish);

		Traits.Add(new RacialTrait
		{
			Name = "DarkVision",
			Description = "You can see in dim light within 60 feet..."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Gnome Cunning",
			Description = "You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic."
		});
	}
}