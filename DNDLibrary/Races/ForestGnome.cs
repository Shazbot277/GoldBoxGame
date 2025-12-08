namespace DNDLibrary.Races;

public class ForestGnome : Gnome
{
	public override string Name => "Forest Gnome";
	public override string Description => "A forest gnome has a natural knack for illusion and can speak with small beasts.";
	public ForestGnome()
	{
		AbilityScoreModifiers[Ability.Dexterity] = 1;
		Traits.Add(new RacialTrait
		{
			Name = "Natural Illusionist",
			Description = "You know the Minor Illusion cantrip. Intelligence is your spellcasting ability for it."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Speak with Small Beasts",
			Description = "Through sounds and gestures, you can communicate simple ideas with Small or smaller beasts."
		});
	}
}